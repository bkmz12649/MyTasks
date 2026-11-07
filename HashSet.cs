using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> ints = new HashSet<int>();
        ints.Add(1);
        ints.Add(2);
        ints.Add(2);
        ints.Add(3);
        ints.Add(3);
        ints.Add(3);

        Console.WriteLine(ints.Count);
    }


}
