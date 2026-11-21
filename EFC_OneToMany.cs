using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using var db = new AppDbContext(); // Подключение к БД

        db.Database.Migrate();

        if (!db.Authors.Any())
        {
            var author1 = new Author
            {
                Name = "Лев Толстой",
                Books = new List<Book>
                {

                    new Book { Title = "Война и мир", Year = 1869 },
                    new Book { Title = "Анна Каренина", Year = 1877 }
                }
            };

            var author2 = new Author
            {
                Name = "Джон Скит",
                Books = new List<Book>
                {
                new Book { Title = "C# in Depth", Year = 2019 }
                }
            };

            db.Authors.AddRange(author1, author2);
            db.SaveChanges();
        }

        // Читаем данные
        Console.WriteLine("\nСписок всех книг:");
        var authors = db.Authors.Include(a => a.Books).AsNoTracking().ToList(); // Только чтение
    

        foreach (var author in authors)
        {
            Console.WriteLine($"\nАвтор: {author.Name}");
            foreach (var book in author.Books)
            {
                Console.WriteLine($" - {book.Title} ({book.Year})");
            }
        }


    }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public int AuthorId { get; set; } // Внешний ключ
        public Author Author { get; set; } // Связь
        

    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new();
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = library_ef.db");
        }
    }
}
