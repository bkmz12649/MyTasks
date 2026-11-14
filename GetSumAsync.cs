using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static async Task Main()
    {
        int res = await GetSumAsync(3, 4);
        Console.WriteLine(res);
    }

    public static async Task<int> GetSumAsync(int a, int b)
    {
        await Task.Delay(1000);
        return a + b;
    }
}
