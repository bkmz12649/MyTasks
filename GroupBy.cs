using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Salary = 50000 },
            new Employee { Name = "Bob", Salary = 60000 },
            new Employee { Name = "Charlie", Salary = 60000 },
            new Employee { Name = "Dave", Salary = 40000 }
        };

        Employee employee60 = employees.FirstOrDefault(e => e.Salary == 60000); //Ищем первого в списке работника с ЗП 60к
        Console.WriteLine(employee60.Name);
        Console.WriteLine(employees.Any(e => e.Salary > 100000)); //Есть ли работник с ЗП больше 100к
        Console.WriteLine();

        var groups = employees.GroupBy(e => e.Salary);

        foreach ( var group in groups )
        {
            Console.Write($"ЗП {group.Key}: ");
            foreach(var employee in group)
            {
                Console.Write($"{employee.Name + " "}");
            }
            Console.WriteLine();
        }
    }


}

public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}


