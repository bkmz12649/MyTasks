using System;
class Program
{
    static void Main()
    {
        var file = new FileManager("test.txt");
        using (file)
        {
            Console.WriteLine("Файл используется...");
        }
    }

}

public class FileManager : IDisposable
{
    private string _path;
    private bool _isOpen;
    public FileManager(string path)
    {
        _path = path;
        _isOpen = true;
        Console.WriteLine("Файл открыт");
    }

    public void Dispose()
    {
        if (_isOpen)
        {
            _isOpen = false;
            Console.WriteLine("Файл закрыт");
        }
    }
}
