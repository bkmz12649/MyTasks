using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using var db = new AppDbContext(); // Подключение к БД

        db.Database.EnsureCreated(); // Создаем бд

        if (!db.Books.Any()) // Добавляем данные, если таблица пуста
        {
            db.Books.Add(new Book { Title = "Война и мир", Author = "Лев Толстой", Year = 1869 });
            db.Books.Add(new Book { Title = "C# in Depth", Author = "Jon Skeet", Year = 2019 });
            db.Books.Add(new Book { Title = "Чистый код", Author = "Роберт Мартин", Year = 2008 });
            db.Books.Add(new Book { Title = "Мастер и Маргарита", Author = "Булгаков", Year = 1967 });

            db.SaveChanges(); // Сохраняем изменения в БД
        }

        // Читаем данные
        Console.WriteLine("\nСписок всех книг:");
        var books = db.Books.ToList(); // EF Core сделает SELECT * FROM Books

        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.Id} | {book.Title} ({book.Author}, {book.Year})");
        }

        //Запрос с фильтрацией
        Console.WriteLine("Книги изданные после 2000 года");
        var after2000books = db.Books.Where(book => book.Year > 2000).ToList();

        foreach(var book in after2000books)
        {
            Console.WriteLine($"ID: {book.Id} | {book.Title} ({book.Author}, {book.Year})");
        }
    }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = library_ef.db");
        }
    }
}
