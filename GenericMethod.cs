using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        string[] strings = { "Hi", "Hello", "Privet" };

        PrintArray<int>(nums);
        PrintArray<string>(strings);
    }

    public static void PrintArray<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.WriteLine(item);
        }
    }
}

