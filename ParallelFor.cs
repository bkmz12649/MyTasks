using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {
        Parallel.For(1, 10, i =>
        {
            Console.WriteLine(i*i);
        });

    }

}
