using System;
using System.Collections.Generic;

public class NewClass
{
    static void Main()
    {
        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Pranik",
            Gender = "Male",
        };
        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "Keval",
            Gender = "Male",
        };
        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Pranali",
            Gender = "Female",
        };

        Stack<Customer> stackCustomers = new Stack<Customer>();
        stackCustomers.Push(customer1);
        stackCustomers.Push(customer2);
        stackCustomers.Push(customer3);

        Console.WriteLine("Count= {0}", stackCustomers.Count);

        Customer c1 = stackCustomers.Pop();
        Console.WriteLine(c1.ID +"-"+ c1.Name +"-"+c1.Gender);
        Console.WriteLine("Count= {0}", stackCustomers.Count);

        Customer c2 = stackCustomers.Pop();
        Console.WriteLine(c2.ID + "-" + c2.Name + "-" + c2.Gender);
        Console.WriteLine("Count= {0} ", stackCustomers.Count);

        Customer c3 = stackCustomers.Pop();
        Console.WriteLine(c3.ID + "-" + c3.Name + "-" + c3.Gender);
        Console.WriteLine("Count= {0} ", stackCustomers.Count);
    }
}

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
}
