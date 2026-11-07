using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> actions = new Stack<string>();
        actions.Push("Open");
        actions.Push("Write");
        actions.Push("Save");

        while(actions.Count > 0)
        {
            Console.WriteLine(actions.Pop());
        }
    }


}
