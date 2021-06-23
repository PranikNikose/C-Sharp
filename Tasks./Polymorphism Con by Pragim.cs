using System;

public class Employee
{
    public string FName= "FN";
    public string LName= "LN";

    public virtual void Fullname()
    {
        Console.WriteLine(FName + " " + LName);
    }
}

public class FullTimeEmployee: Employee
{
    public override void Fullname()
    {
        Console.WriteLine(FName + " " + LName + " " + "- FullTime");
    }

}

public class PartTimeEmployee: Employee
{
    public override void Fullname()
    {
        Console.WriteLine(FName + " " + LName + " " + "- PartTime");
    }

}

public class  TemporaryEmployees: Employee
{
    public override void Fullname()
    {
        Console.WriteLine(FName + " " + LName + " " + "- Temporary");
    }

}

class Program
{
    static void Main()
    {
        var Emp = new Employee[4];

        Emp[0] = new Employee();
        Emp[1] = new PartTimeEmployee();
        Emp[2] = new FullTimeEmployee();
        Emp[3] = new TemporaryEmployees();

        foreach (var e in Emp)
        {
            e.Fullname();
        }

    }
}
