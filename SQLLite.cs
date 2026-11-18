using System;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        // Создаем подключение к базе данных в памяти (она удалится после закрытия программы)
        using var connection = new SqliteConnection("Data Source=:memory:");
        connection.Open();

        // Создаем таблицу и добавляем данные
        var setupCommand = connection.CreateCommand();
        setupCommand.CommandText = @"
            CREATE TABLE Books (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT,
                Author TEXT,
                Year INTEGER,
                Price INTEGER
            );
            INSERT INTO Books (Title, Author, Year, Price) VALUES ('Война и мир', 'Толстой', 1869, 1500);
            INSERT INTO Books (Title, Author, Year, Price) VALUES ('Преступление и наказание', 'Достоевский', 1866, 1200);
            INSERT INTO Books (Title, Author, Year, Price) VALUES ('Мастер и Маргарита', 'Булгаков', 1967, 900);
            INSERT INTO Books (Title, Author, Year, Price) VALUES ('C# in Depth', 'Jon Skeet', 2019, 3000);
        ";
        setupCommand.ExecuteNonQuery();

        Console.WriteLine("База данных создана!");

        // ==========================================
        // ВАША ЗАДАЧА: Напишите SQL-запросы ниже
        // ==========================================

        // Задача 1: Выбрать все книги
        string query1 = @"SELECT * FROM Books;";

        // Задача 2: Выбрать названия и авторов книг, изданных после 2010 года
        string query2 = @"SELECT * FROM Books WHERE Year > 2010"; 

        // Задача 3: Отсортировать книги по цене (от дорогих к дешевым)
        string query3 = @"SELECT * FROM Books ORDER BY Price DESC"; 

        // Задача 4: Поднять цену на 10% для всех книг автора 'Jon Skeet'
        string query4 = @"UPDATE Books SET Price = Price * 1.1 WHERE Author = 'Jon Skeet'"; 

        // Задача 5: Удалить все книги, изданные до 1900 года
        string query5 = @"DELETE FROM Books WHERE Year < 1900"; 


        // Выполняем запросы, чтобы проверить результат
        RunQuery(connection, query1, "Задача 1");
        RunQuery(connection, query2, "Задача 2");
        RunQuery(connection, query3, "Задача 3");

        // Для Задачи 4 и 5 используется ExecuteNonQuery (так как они меняют данные)

        ExecuteNonQuery(connection, query4, "Задача 4");
        ExecuteNonQuery(connection, query5, "Задача 5");
    }

    static void RunQuery(SqliteConnection conn, string sql, string taskName)
    {
        Console.WriteLine($"\n--- {taskName} ---");
        using var command = conn.CreateCommand();
        command.CommandText = sql;

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            // Выводим столбцы через черточку
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetValue(i) + " | ");
            }
            Console.WriteLine();
        }
    }

    static void ExecuteNonQuery(SqliteConnection conn, string sql, string taskName)
    {
        Console.WriteLine($"\n--- {taskName} (Выполнение) ---");
        using var command = conn.CreateCommand();
        command.CommandText = sql;
        int rowsAffected = command.ExecuteNonQuery();
        Console.WriteLine($"Затронуто строк: {rowsAffected}");
    }
}
