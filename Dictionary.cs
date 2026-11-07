using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary["яблоко"] = "apple";
        dictionary["собака"] = "dog";
        dictionary["кошка"] = "cat";

        Console.Write("Введите слово: ");
        string word = Console.ReadLine();
        string translation;

        if (word != null && dictionary.TryGetValue(word, out translation)) 
        {
            Console.WriteLine(translation);
        }
        else
        {
            Console.WriteLine("Слово не найдено");
        }
        
    }


}
