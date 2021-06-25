using System;
public struct Customer
{
    //Fields
    private int _id;
    private string _Name;

    //Public Properties
    public int ID
    {
        get { return this._id;  }
        set { this._id = value; }
    }
    public string Name 
    { 
        get => _Name; 
        set => _Name = value; 
    }

    //Constructor
    public Customer(int Id, String Name)
    {
        this._id = Id;
        this._Name = Name;
    }

    //Method
    public void Details()
    {
        Console.WriteLine("ID = {0} && Name = {1}",this._id,this._Name);
    }
}

class program
{
static void Main()
    {
        var c1 = new Customer(10, "Pranik");
        c1.Details();

        var c2 = new Customer();
        c2.ID = 11;
        c2.Name = "Keval";
        c2.Details();

        var C3 = new Customer
        {
            ID = 12,
            Name = "Nikose"
        };
        C3.Details();
    }
}

