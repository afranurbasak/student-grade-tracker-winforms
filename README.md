# Student Grade Tracker

## 🇹🇷 Türkçe

### Proje Hakkında
Öğrencileri ve aldıkları dersleri kaydetmek, ders bazında ağırlıklı ortalama hesaplamak ve geçti/kaldı durumunu göstermek için geliştirilmiş bir masaüstü uygulamasıdır. Kod, arayüzden ayrılmış **Model** ve **Controller** katmanları ile düzenlenmiştir.

### Özellikler
- Öğrenci ekleme (ad, soyad, numara, bölüm); eksik bilgi ve aynı numara kontrolü
- Seçilen öğrenciye ders ekleme (ders adı, ders kodu, kredi, vize ve final notu)
- Ortalama hesabı: vizenin %40'ı + finalin %60'ı; 50 ve üzeri "Geçti"
- Öğrencinin derslerini ortalama ve durum bilgisiyle listeleme
- Sayısal alanlar için giriş doğrulaması
- Üç sekmeli arayüz: Öğrenci Ekle, Ders Ekle / Not Girişi, Dersleri Listele

### Kullanılan Teknolojiler
C#, Windows Forms, .NET Framework, LINQ

### Kurulum
1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/afranurbasak/student-grade-tracker-winforms.git
   ```
2. `OgrenciNotSistemi.sln` dosyasını Visual Studio ile açın.

### Kullanım
Projeyi çalıştırın (F5). Önce "Öğrenci Ekle" sekmesinden öğrenci kaydedin, ardından "Ders Ekle / Not Girişi" sekmesinde öğrenciyi seçip ders ve not bilgilerini girin. "Dersleri Listele" sekmesinde ortalamaları ve geçme durumunu görebilirsiniz. Veriler uygulama açıkken bellekte tutulur.

### Proje Yapısı
```
OgrenciNotSistemi/
  Model/Student.cs, Model/Course.cs
  Controller/StudentController.cs
  Form1.cs                      # arayüz
```

Arayüz metinleri Türkçedir.

## 🇬🇧 English

### About the Project
A desktop application for recording students and their courses, calculating a weighted average per course and showing pass/fail status. The code is organised into **Model** and **Controller** layers that are separate from the user interface.

### Features
- Adding students (name, surname, student number, department) with missing-field and duplicate-number checks
- Adding courses to a selected student (course name, course code, credits, midterm and final scores)
- Average calculation: 40% midterm + 60% final; 50 or above is "Passed"
- Listing a student's courses with average and status
- Input validation for numeric fields
- Three-tab interface: Add Student, Add Course / Enter Grades, List Courses

### Technologies
C#, Windows Forms, .NET Framework, LINQ

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/afranurbasak/student-grade-tracker-winforms.git
   ```
2. Open `OgrenciNotSistemi.sln` in Visual Studio.

### Usage
Run the project (F5). First add a student in the "Öğrenci Ekle" (Add Student) tab, then select the student in the "Ders Ekle / Not Girişi" (Add Course / Enter Grades) tab and enter the course and grade details. The "Dersleri Listele" (List Courses) tab shows averages and pass status. Data is kept in memory while the application is running.

### Project Structure
```
OgrenciNotSistemi/
  Model/Student.cs, Model/Course.cs
  Controller/StudentController.cs
  Form1.cs                      # user interface
```

The user interface is in Turkish.
