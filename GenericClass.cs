using System;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main()
    {
        Box<int> box1 = new Box<int>();
        Box<string> box2 = new Box<string>();
        box1.Tvalue = 12;
        box2.Tvalue = "string value";

        box1.Show();
        box2.Show();
    }
}

public class Box<T>
{
    public T Tvalue { get; set; }
    public void Show()
    {
        Console.WriteLine(Tvalue);
    }
}
