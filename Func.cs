using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        Func<int, bool> isPositive = x => x >= 0;
        Console.WriteLine(isPositive(-5));
        Console.WriteLine(isPositive(3));
    }
    

}

