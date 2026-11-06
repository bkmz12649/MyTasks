using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        Calculator calc = Add;
        int res = calc(2, 4);
        Console.WriteLine(res);
    }
    public static int Add(int x, int y) => x + y;

}

public delegate int Calculator(int x, int y);
