using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        Action<string> hello = x => Console.WriteLine(x + "!");
        hello("hello");
    }


}


