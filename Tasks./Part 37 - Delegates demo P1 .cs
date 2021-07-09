using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        var emplist = new List<Employee>();
        emplist.Add(new Employee() { ID = 101, Name = "Pranik", Salry = 1000, Experience = 5 });
        emplist.Add(new Employee() { ID = 102, Name = "Nikose", Salry = 5000, Experience = 8});
        emplist.Add(new Employee() { ID = 103, Name = "Scube", Salry = 7000, Experience = 3 });
        emplist.Add(new Employee() { ID = 104, Name = "Boss", Salry = 4000, Experience = 7 });

        Employee.PromoteEmployee(emplist);
    }
}
 class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salry { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> EmployeeList)
    {
        foreach (var e in  EmployeeList)
        {
            if (e.Experience>=5)
            {
                Console.WriteLine(e.Name + " Promoted");
            }
        }
    }
}
