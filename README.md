# 🩸 Kan ve Organ Bağış Takip Otomasyonu ("KAN VE CAN")

Bu proje, hastaneler ve sağlık kuruluşları için geliştirilmiş; kan stoklarını yönetmek, organ bağışı süreçlerini izlemek ve hayati önem taşıyan eşleşmeleri algoritmik olarak gerçekleştirmek amacıyla tasarlanmış kapsamlı bir otomasyon sistemidir.

## 📹 Proje Tanıtım Videosu
> **Not:** Projenin tüm özelliklerini (Giriş, Stok Takibi, Akıllı Eşleşme, Raporlama) aşağıdaki videodan hızlıca izleyebilirsiniz.




https://github.com/user-attachments/assets/cc2887d7-2a94-4241-827b-3bf149ff8e08


---

## 🚀 Projenin Amacı
Manuel kayıt sistemlerindeki hataları sıfıra indirmek, organ nakli bekleyen hastalar için en adil ve tıbbi önceliklere uygun eşleşmeyi saniyeler içinde yapmak ve veri güvenliğini sağlamaktır.

## 🛠️ Kullanılan Teknolojiler
* **Programlama Dili:** C# (Windows Forms Application)
* **Veritabanı:** Microsoft SQL Server
* **Veri Erişimi:** Entity Framework (Code-First Yaklaşımı)
* **Raporlama:** Microsoft RDLC Report Viewer
* **Mimari:** Katmanlı Mimari (N-Tier Architecture)

## ⭐ Temel Özellikler

### 1. Güvenlik ve Yetkilendirme
* Rol bazlı giriş sistemi (Admin / Personel).
* Kullanıcı doğrulama ve hesap kilitleme mekanizmaları.

### 2. Akıllı Organ Eşleşme Algoritması 
* Sistem; Kan Grubu, Rh Faktörü, Doku Uyumu ve **Aciliyet Durumu** (Kritik > Acil > Normal) kriterlerine göre bekleyen hastaları otomatik puanlar.
* Bir bağış yapıldığında en uygun hastayı otomatik olarak en üste getirir.

### 3. Kan Stok Yönetimi
* Bağışlanan kanların barkod sistemi ile takibi.
* SKT (Son Kullanma Tarihi) kontrolü ve stok durumu analizi.
* Laboratuvar test onayı (Hepatit/HIV vb. testlerden geçmeyen kanlar imha edilir).

### 4. Dinamik Raporlama
* Anlık grafikler ile kan grubu dağılımları.
* Bölge ve şehre göre bağışçı istatistikleri.
* PDF ve Excel formatında çıktı alabilme.

---

## 💻 Kurulum ve Çalıştırma

1.  Projeyi sağ üstteki **Code -> Download ZIP** butonundan indirin.
2.  Klasörü RAR'dan çıkarın.
3.  **Önemli:** `KanBagisOtomasyonuDB-query_V3.sql` dosyasını SQL Server'da çalıştırarak veritabanını oluşturun.
4.  `KanOrganBagisTakipOtomasyonu.sln` dosyasını Visual Studio ile açıp başlatın.

---
*Geliştirici: Eda Pekdurlan*
