# 📚 Kütüphane Yönetim Sistemi

Bu proje, bir kütüphane yönetim sisteminin temel işleyişini modellemek için geliştirilmiştir. Proje, yazarlar ve kitaplar arasında bir ilişki kurar ve LINQ sorguları kullanılarak kitaplarla yazarların bilgileri birleştirilir.

---

## 🚀 Projenin Özellikleri

- **Yazarlar (Authors)** ve **Kitaplar (Books)** tablolarını temsil eden iki sınıf bulunmaktadır.
- Yazarlar ve kitaplar arasında **birçoktan bire** (many-to-one) ilişki kurulmuştur.
- LINQ kullanılarak **join** işlemi ile yazar ve kitap bilgileri birleştirilmiştir.
- Ekrana her kitabın başlığı ve yazarının adı yazdırılmaktadır.

---

## 💻 Kullanılan Teknolojiler

- **Dil**: C#
- **Platform**: .NET Framework veya .NET Core
- **Yöntem**: LINQ sorguları
- **IDE**: Visual Studio veya benzeri bir C# geliştirme ortamı

---

## 🛠️ Kurulum ve Çalıştırma

1. **Projeyi Kopyalayın**:
   - Bu projeyi bilgisayarınıza indirin veya kopyalayın.

2. **Geliştirme Ortamını Açın**:
   - Visual Studio veya tercih ettiğiniz bir C# IDE'sini açın.

3. **Kodları Derleyin ve Çalıştırın**:
   - Projeyi derleyin.
   - `Main` metodu çalıştırıldığında sonuçları konsolda görebilirsiniz.

---

## 📂 Proje Yapısı

### `Author` Sınıfı
- `AuthorId` (int): Yazarın benzersiz kimlik numarası.
- `Name` (string): Yazarın adı.

### `Book` Sınıfı
- `BookId` (int): Kitabın benzersiz kimlik numarası.
- `Title` (string): Kitabın başlığı.
- `AuthorId` (int): Kitabın yazarına işaret eden kimlik numarası.

---

## 🔍 LINQ Sorgusu

Projede kullanılan LINQ sorgusu ile:
- **Kitaplar** ve **Yazarlar** tabloları `AuthorId` üzerinden birleştirilir.
- Her kitabın başlığı ve yazarının adı birleştirilmiş şekilde ekrana yazdırılır.

---

## 📝 Örnek Çıktı

Program çalıştırıldığında konsolda şu şekilde bir çıktı görebilirsiniz:


 
