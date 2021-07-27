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

        Queue<Customer> QC = new Queue<Customer>();
        QC.Enqueue(customer1);
        QC.Enqueue(customer2);
        QC.Enqueue(customer3);

        Console.WriteLine("Count= {0}", QC.Count);

        Customer c1 = QC.Dequeue();
        Console.WriteLine(c1.ID +"-"+ c1.Name +"-"+c1.Gender);
        Console.WriteLine("Count= {0}", QC.Count);

        Customer c2 = QC.Dequeue();
        Console.WriteLine(c2.ID + "-" + c2.Name + "-" + c2.Gender);
        Console.WriteLine("Count= {0} ", QC.Count);

        Customer c3 = QC.Dequeue();
        Console.WriteLine(c3.ID + "-" + c3.Name + "-" + c3.Gender);
        Console.WriteLine("Count= {0} ", QC.Count);
    }
}

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
}
