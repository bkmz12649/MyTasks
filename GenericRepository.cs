using System;
using System.Globalization;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Repository<string> nums = new Repository<string>(new [] { "one",  "two", "three" });
        List<string> nums1 = nums.GetAll();

        foreach (string s in nums1)
        {
            Console.WriteLine(s);
        }
    }

}

public class Repository<T> where T : class
{
    private List<T> _items = new List<T>();

    public Repository(IEnumerable<T> items)
    {
        foreach(T item in items)
        {
            Add(item);
        }
    }

    public void Add(T item)
    {
        if(item != null)
        {
            _items.Add(item);
        }
    }

    public List<T> GetAll()
    {
        return new List<T>(_items);
    }
}

