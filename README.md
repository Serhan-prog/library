# 📚 Kütüphane Yönetim Sistemi (Library Management System)

C# WinForms ve SQL Server mimarisi üzerine inşa edilmiş, modern arayüzlü bir kütüphane takip otomasyonudur. Bu proje; kitapların durumunu (rafta/emanette), üye kayıtlarını ve iade süreçlerini profesyonel bir şekilde yönetmek için tasarlanmıştır.

## 🚀 Öne Çıkan Özellikler

* **Dinamik Dashboard:** Toplam kitap, üye ve aktif emanet sayılarını tek ekranda görüntüleme.
* **Gelişmiş Emanet Sistemi:** Kitap ödünç verme ve iade alma süreçlerinde otomatik "Mevcut" (Availability) kontrolü.
* **Akıllı Arama:** Kitap ve üye listelerinde anlık (instant) filtreleme.
* **Güvenli Veri Yönetimi:** `SqlTransaction` yapısı ile iade işlemlerinde veri tutarlılığı garantisi.
* **Modern UI:** DataGridView üzerinde özel renklendirme ve kullanıcı dostu arayüz tasarımı.

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C# (.NET)
* **Arayüz:** Windows Forms (WinForms)
* **Veritabanı:** Microsoft SQL Server (MSSQL)
* **Veri Erişimi:** ADO.NET & Microsoft.Data.SqlClient

## 🔧 Başlangıç
Bu projeyi yerel makinenize indirin.

Library_Management_System klasöründeki kodlarda yer alan connectionString değişkenini kendi yerel SQL Server adresinize göre düzenleyin:
Server=.\SQLEXPRESS; Database=LibraryDB; Integrated Security=True; TrustServerCertificate=True;

Visual Studio ile projeyi açın ve Build ederek çalıştırın.

## 📋 Veritabanı Kurulumu (SQL Script)

Projeyi çalıştırmadan önce SQL Server Management Studio (SSMS) üzerinde aşağıdaki sorguyu çalıştırarak veritabanını ve gerekli tabloları oluşturun:

```sql
-- 1. Veritabanı Oluşturma
CREATE DATABASE LibraryDB;
GO        
USE LibraryDB;
GO

-- 2. Kullanıcılar Tablosu (Giriş Paneli)
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    FullName NVARCHAR(100)
);

-- 3. Kitaplar Tablosu
CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL,
    Author NVARCHAR(100),
    ISBN NVARCHAR(20),
    PageCount INT,
    IsAvailable BIT DEFAULT 1 -- 1: Mevcut, 0: Emanette
);

-- 4. Üyeler Tablosu
CREATE TABLE Members (
    MemberID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(15),
    Email NVARCHAR(100)
);

-- 5. Emanet İşlemleri (Transaction) Tablosu
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    BookID INT FOREIGN KEY REFERENCES Books(BookID),
    MemberID INT FOREIGN KEY REFERENCES Members(MemberID),
    BorrowDate DATETIME DEFAULT GETDATE(), -- Veriliş Tarihi
    ReturnDate DATETIME NOT NULL,           -- Beklenen İade Tarihi
    ActualReturnDate DATETIME NULL         -- Gerçek İade Tarihi (Kitap gelince güncellenir)
);

-- Örnek Admin Hesabı
INSERT INTO Users (Username, Password, FullName) 
VALUES ('admin', '1', 'Serhan Bozdemir');
