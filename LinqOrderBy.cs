using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> words = new List<string> { "яблоко", "дом", "автомобиль", "кот" };

        var sorted = words.OrderBy(x => x.Length);

        foreach (var word in sorted)
        {
            Console.WriteLine(word);
        }
    }


}
