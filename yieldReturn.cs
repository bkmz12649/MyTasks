using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int count = 0;
        foreach (int a in GetFib())
        {
            Console.WriteLine(a);
            count ++;
            if (count == 10)
            {
                break;
            }
        }
    }

    public static IEnumerable<int> GetFib()
    {
        int a = 0;
        int b = 1; 

        while (true)
        {
            yield return a;
            int temp = a;
            a = b;
            b += temp;
        }
    }


}

