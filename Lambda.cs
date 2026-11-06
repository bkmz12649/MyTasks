using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        List<int> numsBiggerthree = nums.FindAll(x => x > 3);

        foreach(int num in numsBiggerthree)
        {
            Console.WriteLine(num);
        }
    }


}


