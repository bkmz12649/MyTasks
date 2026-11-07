using System;

class Program
{
    static void Main()
    {
        List<string> persons = new List<string>() { "Mike", "Henry", "Sam"};
        persons.Remove(persons[1]); // По значению
        persons.RemoveAt(0); // По индексу

        foreach (string person in persons)
        {
            Console.WriteLine(person);
        }

    }


}
