using System;
class Program
{
    static void Main()
    {
        Customer[] customersAll = new Customer[3];

        customersAll[0] = new Customer
        {
            Name = "Mark",
            Gender = Gender.Male
        };
        customersAll[1] = new Customer
        {
            Name = "Mary",
            Gender = Gender.Female
        };
        customersAll[2] = new Customer
        {
            Name = "John",
            Gender = Gender.Unknown
        };

        foreach(Customer c in customersAll)
        {
            Console.WriteLine("Name= {0}  && Gender = {1} ",c.Name ,c.Gender);
        }
    }
}

public enum Gender
{ 
    Unknown,
    Male,
    Female
}

public class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}


