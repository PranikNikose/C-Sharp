using System;

public class Employee
{
    public string FName;
    public string LName;

    public void Fullname()
    {
        Console.WriteLine(FName+" "+ LName);
    }
}

public class FullTimeEmployee: Employee
{
    float FullSalary;
}

public class PartTimeEmployee
{
    float PartSalary;
}

class Program
{
    static void Main()
    {
        var c1 = new FullTimeEmployee();
        c1.FName = "Pranik";
        c1.LName = "Nikose";
        c1.Fullname();
    }
}
