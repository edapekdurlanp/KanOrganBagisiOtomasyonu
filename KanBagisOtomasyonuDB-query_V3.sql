USE KanOrganBagisDB -- Veritabaný ismin neyse onu yaz
GO

-- =========================================================
-- 1. BÖLÜM: TEMÝZLÝK (DROP TABLES)
-- Ýliþki sýrasýna göre tersten siliyoruz ki hata vermesin.
-- =========================================================

IF OBJECT_ID('dbo.transfers', 'U') IS NOT NULL DROP TABLE dbo.transfers;
IF OBJECT_ID('dbo.requests', 'U') IS NOT NULL DROP TABLE dbo.requests;
IF OBJECT_ID('dbo.organ_donations', 'U') IS NOT NULL DROP TABLE dbo.organ_donations;
IF OBJECT_ID('dbo.blood_stocks', 'U') IS NOT NULL DROP TABLE dbo.blood_stocks;
IF OBJECT_ID('dbo.lab_tests', 'U') IS NOT NULL DROP TABLE dbo.lab_tests;
IF OBJECT_ID('dbo.blood_donations', 'U') IS NOT NULL DROP TABLE dbo.blood_donations;
IF OBJECT_ID('dbo.health_questionnaires', 'U') IS NOT NULL DROP TABLE dbo.health_questionnaires;
IF OBJECT_ID('dbo.patients', 'U') IS NOT NULL DROP TABLE dbo.patients;
IF OBJECT_ID('dbo.donors', 'U') IS NOT NULL DROP TABLE dbo.donors;
IF OBJECT_ID('dbo.user_logs', 'U') IS NOT NULL DROP TABLE dbo.user_logs;
IF OBJECT_ID('dbo.users', 'U') IS NOT NULL DROP TABLE dbo.users;
IF OBJECT_ID('dbo.role_permissions', 'U') IS NOT NULL DROP TABLE dbo.role_permissions;
IF OBJECT_ID('dbo.permissions', 'U') IS NOT NULL DROP TABLE dbo.permissions;
IF OBJECT_ID('dbo.roles', 'U') IS NOT NULL DROP TABLE dbo.roles;
IF OBJECT_ID('dbo.departments', 'U') IS NOT NULL DROP TABLE dbo.departments;
IF OBJECT_ID('dbo.hospitals', 'U') IS NOT NULL DROP TABLE dbo.hospitals;
IF OBJECT_ID('dbo.districts', 'U') IS NOT NULL DROP TABLE dbo.districts;
IF OBJECT_ID('dbo.cities', 'U') IS NOT NULL DROP TABLE dbo.cities;

PRINT 'Eski tablolar temizlendi...';

-- =========================================================
-- 2. BÖLÜM: TABLO OLUÞTURMA (CREATE TABLES)
-- =========================================================

-- COÐRAFÝ VE KURUMSAL
CREATE TABLE cities (
    city_id INT PRIMARY KEY IDENTITY(1,1),
    city_name NVARCHAR(50) NOT NULL
);

CREATE TABLE districts (
    district_id INT PRIMARY KEY IDENTITY(1,1),
    city_id INT FOREIGN KEY REFERENCES cities(city_id),
    district_name NVARCHAR(50) NOT NULL
);

CREATE TABLE hospitals (
    hospital_id INT PRIMARY KEY IDENTITY(1,1),
    hospital_name NVARCHAR(100) NOT NULL,
    city_id INT FOREIGN KEY REFERENCES cities(city_id),
    type NVARCHAR(50) -- Devlet, Özel, Üniversite
);

-- KULLANICI YÖNETÝMÝ
CREATE TABLE departments (
    department_id INT PRIMARY KEY IDENTITY(1,1),
    department_name NVARCHAR(50) NOT NULL
);

CREATE TABLE roles (
    role_id INT PRIMARY KEY IDENTITY(1,1),
    role_name NVARCHAR(50) NOT NULL
);

CREATE TABLE permissions (
    permission_id INT PRIMARY KEY IDENTITY(1,1),
    permission_key NVARCHAR(50) UNIQUE NOT NULL,
    description NVARCHAR(100)
);

CREATE TABLE role_permissions (
    id INT PRIMARY KEY IDENTITY(1,1),
    role_id INT FOREIGN KEY REFERENCES roles(role_id),
    permission_id INT FOREIGN KEY REFERENCES permissions(permission_id)
);

CREATE TABLE users (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    department_id INT FOREIGN KEY REFERENCES departments(department_id),
    role_id INT FOREIGN KEY REFERENCES roles(role_id),
    username NVARCHAR(50) NOT NULL UNIQUE,
    password NVARCHAR(100) NOT NULL,
    name_surname NVARCHAR(100) NOT NULL,
    email NVARCHAR(100),
    is_active BIT DEFAULT 1,
    is_locked BIT DEFAULT 0,
    failed_login_count INT DEFAULT 0,
    last_login_date DATETIME,
    created_date DATETIME DEFAULT GETDATE()
);

CREATE TABLE user_logs (
    log_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT FOREIGN KEY REFERENCES users(user_id),
    action_type NVARCHAR(50),
    description NVARCHAR(500),
    log_date DATETIME DEFAULT GETDATE(),
    ip_address NVARCHAR(20)
);

-- BAÐIÞÇI VE MEDÝKAL
CREATE TABLE donors (
    donor_id INT PRIMARY KEY IDENTITY(1,1),
    tckn NVARCHAR(11) UNIQUE NOT NULL,
    name_surname NVARCHAR(100) NOT NULL,
    birth_date DATE,
    gender NVARCHAR(10),
    blood_type NVARCHAR(5),
    rh_factor NVARCHAR(10),
    weight DECIMAL(5,2),
    city_id INT FOREIGN KEY REFERENCES cities(city_id),
    district_id INT FOREIGN KEY REFERENCES districts(district_id), -- Opsiyonel
    address_detail NVARCHAR(250),
    phone NVARCHAR(20),
    email NVARCHAR(100),
    last_donation_date DATETIME,
    is_organ_donor BIT DEFAULT 0,
    registration_date DATETIME DEFAULT GETDATE()
);

CREATE TABLE health_questionnaires (
    questionnaire_id INT PRIMARY KEY IDENTITY(1,1),
    donor_id INT FOREIGN KEY REFERENCES donors(donor_id),
    form_date DATETIME DEFAULT GETDATE(),
    is_eligible BIT -- Uygun mu?
);

-- KAN SÜRECÝ
CREATE TABLE blood_donations (
    donation_id INT PRIMARY KEY IDENTITY(1,1),
    donor_id INT FOREIGN KEY REFERENCES donors(donor_id),
    hospital_id INT FOREIGN KEY REFERENCES hospitals(hospital_id),
    donation_date DATETIME DEFAULT GETDATE(),
    bag_barcode NVARCHAR(50) UNIQUE,
    amount_ml INT,
    status NVARCHAR(20) DEFAULT 'Karantina', -- Karantina, Onaylandý, ÝmhaEdildi
    rejection_reason NVARCHAR(200)
);

CREATE TABLE lab_tests (
    test_id INT PRIMARY KEY IDENTITY(1,1),
    donation_id INT FOREIGN KEY REFERENCES blood_donations(donation_id),
    test_date DATETIME DEFAULT GETDATE(),
    hepatitis_b BIT,
    hepatitis_c BIT,
    hiv BIT,
    syphilis BIT,
    test_result NVARCHAR(20) -- TEMÝZ, ENFEKTE
);

CREATE TABLE blood_stocks (
    stock_id INT PRIMARY KEY IDENTITY(1,1),
    donation_id INT FOREIGN KEY REFERENCES blood_donations(donation_id),
    product_type NVARCHAR(50), -- Tam Kan, Plazma vb.
    blood_type NVARCHAR(5),
    rh_factor NVARCHAR(10),
    expiration_date DATETIME,
    is_used BIT DEFAULT 0,
    location_shelf NVARCHAR(50),
    entry_date DATETIME DEFAULT GETDATE()
);

-- ORGAN SÜRECÝ
CREATE TABLE organ_donations (
    organ_id INT PRIMARY KEY IDENTITY(1,1),
    donor_id INT FOREIGN KEY REFERENCES donors(donor_id),
    organ_name NVARCHAR(50),
    tissue_type_hla NVARCHAR(50),
    donation_date DATETIME DEFAULT GETDATE(),
    status NVARCHAR(20) DEFAULT 'Bekliyor',
    is_matched BIT DEFAULT 0
);

-- HASTA VE TALEP
CREATE TABLE patients (
    patient_id INT PRIMARY KEY IDENTITY(1,1),
    tckn NVARCHAR(11) UNIQUE NOT NULL,
    name_surname NVARCHAR(100) NOT NULL,
    birth_date DATE,
    blood_type NVARCHAR(5),
    rh_factor NVARCHAR(10),
    hospital_id INT FOREIGN KEY REFERENCES hospitals(hospital_id),
    diagnosis NVARCHAR(MAX),
    urgency_status NVARCHAR(20), -- Acil, Normal
    registration_date DATETIME DEFAULT GETDATE()
);

CREATE TABLE requests (
    request_id INT PRIMARY KEY IDENTITY(1,1),
    patient_id INT FOREIGN KEY REFERENCES patients(patient_id),
    request_type NVARCHAR(20), -- Kan, Organ
    required_product NVARCHAR(50),
    amount INT,
    request_date DATETIME DEFAULT GETDATE(),
    status NVARCHAR(20) DEFAULT 'Bekliyor',
    priority_score INT
);

-- TRANSFER
CREATE TABLE transfers (
    transfer_id INT PRIMARY KEY IDENTITY(1,1),
    request_id INT FOREIGN KEY REFERENCES requests(request_id),
    stock_id INT FOREIGN KEY REFERENCES blood_stocks(stock_id), -- Kan ise dolu
    organ_id INT FOREIGN KEY REFERENCES organ_donations(organ_id), -- Organ ise dolu
    courier_name NVARCHAR(100),
    departure_time DATETIME,
    actual_arrival DATETIME,
    status NVARCHAR(20)
);

PRINT 'Tablolar baþarýyla oluþturuldu...';

-- =========================================================
-- 3. BÖLÜM: VERÝ YÜKLEME (INSERT DATA)
-- Sýralama çok önemli! Parent -> Child
-- =========================================================

-- 1. Þehirler
INSERT INTO cities (city_name) VALUES ('Ýstanbul'), ('Ankara'), ('Ýzmir');

-- 2. Ýlçeler
INSERT INTO districts (city_id, district_name) VALUES 
(1, 'Kadýköy'), (1, 'Þiþli'), (2, 'Çankaya'), (3, 'Konak');

-- 3. Hastaneler (City ID'ler artýk var)
INSERT INTO hospitals (hospital_name, city_id, type) VALUES
('Acýbadem Kadýköy', 1, 'Özel'),
('Þiþli Etfal', 1, 'Devlet'),
('Hacettepe Týp', 2, 'Üniversite'),
('Ege Üniversitesi', 3, 'Üniversite');

-- 4. Departmanlar ve Roller
INSERT INTO departments (department_name) VALUES ('Yönetim'), ('Laboratuvar'), ('Kayýt'), ('Lojistik');
INSERT INTO roles (role_name) VALUES ('Admin'), ('Personel'), ('Doktor');

-- 5. Kullanýcýlar (Artýk departman ve rol var, hata vermez)
INSERT INTO users (department_id, role_id, username, password, name_surname, is_active) VALUES
(1, 1, 'admin', '1234', 'Eda Pekdurlan', 1), -- ID:1
(2, 2, 'lab1', '1234', 'Mehmet Testçi', 1),   -- ID:2
(3, 2, 'kayit1', '1234', 'Ayþe Kayýtçý', 1); -- ID:3

-- 6. Baðýþçýlar (Donors)
INSERT INTO donors (tckn, name_surname, birth_date, gender, blood_type, rh_factor, city_id, phone, is_organ_donor, last_donation_date) VALUES
('11111111111', 'Ahmet Yýlmaz', '1990-05-20', 'Erkek', 'A', '+', 1, '5551112233', 1, DATEADD(day, -100, GETDATE())), -- ID:1
('22222222222', 'Zeynep Kaya', '1995-08-15', 'Kadýn', '0', '-', 1, '5324445566', 0, DATEADD(day, -10, GETDATE())),  -- ID:2
('33333333333', 'Murat Demir', '1988-01-10', 'Erkek', 'B', '+', 2, '5057778899', 1, DATEADD(day, -200, GETDATE())), -- ID:3
('44444444444', 'Elif Çelik', '2000-11-30', 'Kadýn', 'AB', '+', 3, '5421110000', 0, NULL),                          -- ID:4
('55555555555', 'Caner Erkin', '1992-03-03', 'Erkek', 'A', '-', 1, '5352223344', 0, DATEADD(day, -40, GETDATE()));    -- ID:5

-- 7. Kan Baðýþlarý (Artýk Donor ID'ler var, hata vermez)
INSERT INTO blood_donations (donor_id, hospital_id, bag_barcode, amount_ml, status, donation_date) VALUES
(1, 1, 'BAR-20231201-1001', 450, 'Onaylandý', DATEADD(day, -5, GETDATE())), -- Ahmet A+
(3, 3, 'BAR-20231201-1002', 450, 'Onaylandý', DATEADD(day, -4, GETDATE())), -- Murat B+
(5, 1, 'BAR-20231201-1003', 450, 'Onaylandý', DATEADD(day, -3, GETDATE())), -- Caner A-
(2, 2, 'BAR-20231201-9999', 450, 'ÝmhaEdildi', DATEADD(day, -2, GETDATE())), -- Zeynep 0- (Hasta çýktý diyelim)
(4, 3, 'BAR-20231204-NEW1', 450, 'Karantina', GETDATE());                    -- Elif AB+ (Test bekliyor)

-- 8. Test Sonuçlarý
INSERT INTO lab_tests (donation_id, test_date, hepatitis_b, hepatitis_c, hiv, syphilis, test_result) VALUES
(1, GETDATE(), 0, 0, 0, 0, 'TEMÝZ'),
(2, GETDATE(), 0, 0, 0, 0, 'TEMÝZ'),
(3, GETDATE(), 0, 0, 0, 0, 'TEMÝZ'),
(4, GETDATE(), 1, 0, 0, 0, 'ENFEKTE'); -- Zeynep'in kaný

-- 9. Stok Giriþleri
INSERT INTO blood_stocks (donation_id, product_type, blood_type, rh_factor, expiration_date, is_used, location_shelf) VALUES
(1, 'Tam Kan', 'A', '+', DATEADD(day, 30, GETDATE()), 0, 'RAF-A1'),
(2, 'Eritrosit Süspansiyonu', 'B', '+', DATEADD(day, 35, GETDATE()), 0, 'RAF-B1'),
(3, 'Taze Donmuþ Plazma', 'A', '-', DATEADD(day, 60, GETDATE()), 0, 'RAF-C1');

-- 10. Organ Baðýþý Havuzu
INSERT INTO organ_donations (donor_id, organ_name, status, is_matched, donation_date) VALUES
(1, 'Böbrek', 'Bekliyor', 0, GETDATE()), 
(3, 'Karaciðer', 'Bekliyor', 0, GETDATE());

-- 11. Hastalar (Patients)
INSERT INTO patients (tckn, name_surname, birth_date, blood_type, rh_factor, hospital_id, diagnosis, urgency_status) VALUES
('99911111111', 'Fatma Teyze', '1960-01-01', 'A', '+', 1, 'Böbrek Yetmezliði', 'Kritik'),
('99922222222', 'Ali Veli', '1985-05-05', '0', '-', 2, 'Trafik Kazasý', 'Acil');

-- 12. Talepler
INSERT INTO requests (patient_id, request_type, required_product, status) VALUES
(1, 'Organ', 'Böbrek', 'Bekliyor'),   -- Fatma Teyze, Ahmet'in böbreði ile eþleþebilir
(2, 'Kan', '0 Rh- Tam Kan', 'Bekliyor'); -- Ali Veli kan bekliyor

-- 13. Transferler (Örnek bir geçmiþ kayýt)
INSERT INTO transfers (request_id, courier_name, status, departure_time, actual_arrival) VALUES
(2, 'Ali Kurye', 'Yolda', DATEADD(hour, -1, GETDATE()), NULL);

PRINT 'TÜM ÝÞLEMLER BAÞARIYLA TAMAMLANDI. SÝSTEM KULLANIMA HAZIR!';