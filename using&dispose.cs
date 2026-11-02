using System;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main()
    {
        try
        {
            using (var connection = new DatabaseConnection())
            {
                Console.WriteLine("БД используется");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}

public class DatabaseConnection : IDisposable
{

    public DatabaseConnection()
    {
        Console.WriteLine("Подключение к БД открыто");
    }
    public void ExecuteQuery()
    {
        throw new Exception("Ошибка БД");
    }
    public void Dispose()
    {
        Console.WriteLine("Подключение к БД закрыто");
    }


}
