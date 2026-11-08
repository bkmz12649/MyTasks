using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        string[] array = { "1", "2", "3"};
        list.Add("1");
        list.Add("2");
        list.Add("3");
        PrintAll(list);
        PrintAll(array);
    }

    public static void PrintAll(IEnumerable<string> strings)
    {
        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }
    }


}
