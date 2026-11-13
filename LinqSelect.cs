using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        var values = nums.Select(x => x * x);//Запрос создан

        foreach (int value in values) //Запрос обработан
        {
            Console.WriteLine(value);
        }
    }


}
