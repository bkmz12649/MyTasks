using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static async Task Main()
    {
        await PrintWithDelay("Hello World!");
    }

    public static async Task PrintWithDelay(string text)
    {
        await Task.Delay(2000);
        Console.WriteLine(text);
    }
}
