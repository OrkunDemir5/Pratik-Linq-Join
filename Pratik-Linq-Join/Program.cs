using Pratik_Linq_Join;
using System;

// Verilerin Eklenmesi
List<Author> authors = new List<Author>
{
    new Author { AuthorId = 1, Name = "Orhan Pamuk"},
    new Author { AuthorId = 2, Name = "Elif Şafak"},
    new Author { AuthorId = 3, Name = "Ahmet Ümit"}

};

List<Book> books = new List<Book>
{

    new Book { BookId =1 , Title = "Kar", AuthorId = 1 },
    new Book { BookId =2 , Title = "İstanbul", AuthorId = 1 },
    new Book { BookId =3 , Title = "10 Minutes 38 Second in This Strange World", AuthorId = 2 },
    new Book { BookId =4 , Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
};

// LINQ Sorgusu ile Tabloların Birleştirilmesi

var bookAuthorJoin = from Book in books // books listesindeki her bir kitap için
                     join Author in authors
                     on Book.AuthorId equals Author.AuthorId
                     select new // yeni bir anonim nesne oluştur
                     {
                         BookTitle = Book.Title, // kitap başlığı 
                         AuthorName = Author.Name // yazar adı
                     };


Console.WriteLine("Kitaplar ve Yazarlar");
//Sonuçları yazdırma
foreach (var item in bookAuthorJoin)
{
    Console.WriteLine($"Kitap Başlığı: {item.BookTitle}, Yazar: {item.AuthorName}");
}

