-- proje sahibi: eda pekdurlan
-- kan ve organ baðýþý takip sistemi - master veritabaný scripti
-- tüm modüller entegre edilmiþ, normalizasyon kurallarýna uygun yapý

create database KanOrganBagisDB
use KanOrganBagisDB

-- 1. bolum: coðrafi ve kurumsal tanýmlamalar
create table cities (
    city_id int primary key identity(1,1),
    city_name nvarchar(50) not null
);

create table districts (
    district_id int primary key identity(1,1),
    city_id int foreign key references cities(city_id),
    district_name nvarchar(50) not null
);

create table hospitals (
    hospital_id int primary key identity(1,1),
    hospital_name nvarchar(100) not null,
    city_id int foreign key references cities(city_id),
    district_id int foreign key references districts(district_id),
    address_detail nvarchar(250),
    phone nvarchar(20),
    type nvarchar(50) -- devlet, özel, üniversite
);

-- 2. bolum: kullanýcý, rol ve yetki yönetimi (rbac)
create table departments (
    department_id int primary key identity(1,1),
    department_name nvarchar(50) not null,
    description nvarchar(200)
);

create table roles (
    role_id int primary key identity(1,1),
    role_name nvarchar(50) not null, -- admin, doktor, laborant, kurye
    description nvarchar(200)
);

create table permissions (
    permission_id int primary key identity(1,1),
    permission_key nvarchar(50) unique not null,
    description nvarchar(100)
);

create table role_permissions (
    id int primary key identity(1,1),
    role_id int foreign key references roles(role_id),
    permission_id int foreign key references permissions(permission_id)
);

create table users (
    user_id int primary key identity(1,1),
    department_id int foreign key references departments(department_id),
    role_id int foreign key references roles(role_id),
    username nvarchar(50) not null unique,
    password nvarchar(100) not null,
    name_surname nvarchar(100) not null,
    email nvarchar(100),
    phone nvarchar(20),
    identity_number nvarchar(11),
    is_active bit default 1,
    is_locked bit default 0,
    failed_login_count int default 0,
    last_login_date datetime,
    created_date datetime default getdate()
);

create table user_logs (
    log_id int primary key identity(1,1),
    user_id int foreign key references users(user_id),
    action_type nvarchar(50), -- login, insert, delete
    description nvarchar(500),
    log_date datetime default getdate(),
    ip_address nvarchar(20)
);

-- 3. bolum: baðýþçý ve medikal geçmiþ
create table donors (
    donor_id int primary key identity(1,1),
    tckn nvarchar(11) unique not null,
    name_surname nvarchar(100) not null,
    birth_date date,
    gender nvarchar(10),
    blood_type nvarchar(5), -- a, b, ab, 0
    rh_factor nvarchar(10), -- (+), (-)
    weight decimal(5,2),
    height decimal(5,2),
    city_id int foreign key references cities(city_id),
    district_id int foreign key references districts(district_id),
    address_detail nvarchar(250),
    phone nvarchar(20),
    email nvarchar(100),
    profession nvarchar(50),
    last_donation_date datetime,
    is_organ_donor bit default 0,
    registration_date datetime default getdate()
);

-- baðýþ öncesi zorunlu saðlýk formu
create table health_questionnaires (
    questionnaire_id int primary key identity(1,1),
    donor_id int foreign key references donors(donor_id),
    form_date datetime default getdate(),
    has_chronic_disease bit,
    used_drugs_last_24h bit,
    has_infection bit,
    recent_surgery bit,
    travel_history nvarchar(100), -- son 1 ayda yurtdýþý
    is_eligible bit -- sistem otomatik karar verecek: uygun/uygun deðil
);

-- 4. bolum: kan baðýþý, testler ve stok
create table blood_donations (
    donation_id int primary key identity(1,1),
    donor_id int foreign key references donors(donor_id),
    hospital_id int foreign key references hospitals(hospital_id),
    donation_date datetime default getdate(),
    bag_barcode nvarchar(50) unique,
    amount_ml int,
    status nvarchar(20) default 'karantina', -- karantina, testediliyor, onaylandi, imhaedildi
    rejection_reason nvarchar(200)
);

create table lab_tests (
    test_id int primary key identity(1,1),
    donation_id int foreign key references blood_donations(donation_id),
    test_date datetime default getdate(),
    hepatitis_b bit, -- 1:pozitif, 0:negatif
    hepatitis_c bit,
    hiv bit,
    syphilis bit,
    hemoglobin_level decimal(4,2),
    approved_by_user_id int, -- testi onaylayan laborant
    test_result nvarchar(20) -- temiz, enfekte
);

create table blood_stocks (
    stock_id int primary key identity(1,1),
    donation_id int foreign key references blood_donations(donation_id),
    product_type nvarchar(50), -- tam kan, eritrosit, plazma
    blood_type nvarchar(5),
    rh_factor nvarchar(10),
    expiration_date datetime,
    is_used bit default 0,
    location_shelf nvarchar(50),
    entry_date datetime default getdate()
);

-- 5. bolum: organ baðýþý
create table organ_donations (
    organ_id int primary key identity(1,1),
    donor_id int foreign key references donors(donor_id),
    organ_name nvarchar(50), -- kalp, karaciger, bobrek
    tissue_type_hla nvarchar(50), -- doku uyumu kodu
    donation_date datetime default getdate(),
    status nvarchar(20) default 'bekliyor', -- bekliyor, eslesti, transferde
    is_matched bit default 0
);

-- 6. bolum: hastalar ve talepler
create table patients (
    patient_id int primary key identity(1,1),
    tckn nvarchar(11) unique not null,
    name_surname nvarchar(100) not null,
    birth_date date,
    blood_type nvarchar(5),
    rh_factor nvarchar(10),
    hospital_id int foreign key references hospitals(hospital_id),
    diagnosis nvarchar(max),
    urgency_status nvarchar(20), -- acil, normal
    registration_date datetime default getdate()
);

create table requests (
    request_id int primary key identity(1,1),
    patient_id int foreign key references patients(patient_id),
    request_type nvarchar(20), -- kan, organ
    required_product nvarchar(50), -- ab rh+ plazma
    amount int, -- kaç adet
    request_date datetime default getdate(),
    status nvarchar(20) default 'bekliyor', -- bekliyor, karsilandi
    priority_score int -- aciliyet puaný (otomasyon hesaplayacak)
);

-- 7. bolum: transfer ve lojistik
create table transfers (
    transfer_id int primary key identity(1,1),
    request_id int foreign key references requests(request_id),
    stock_id int foreign key references blood_stocks(stock_id), -- null olabilir (organ ise)
    organ_id int foreign key references organ_donations(organ_id), -- null olabilir (kan ise)
    courier_name nvarchar(100),
    vehicle_plate nvarchar(20),
    departure_time datetime,
    estimated_arrival datetime,
    actual_arrival datetime,
    status nvarchar(20) -- yolda, teslimedildi
);

-- 8. bolum: baþlangýç verileri (seed data)
insert into cities (city_name) values ('istanbul'), ('ankara'), ('izmir');
insert into departments (department_name) values ('yönetim'), ('laboratuvar'), ('kayýt');
insert into roles (role_name) values ('admin'), ('doktor'), ('personel');

-- varsayýlan admin kullanýcýsý
insert into users (department_id, role_id, username, password, name_surname, is_active) 
values (1, 1, 'admin', '1234', 'eda pekdurlan', 1);

insert into permissions (permission_key, description) values 
('full_access', 'tam yetki'), 
('can_add_donor', 'baðýþçý ekleme');

insert into role_permissions (role_id, permission_id) values (1, 1), (1, 2);

