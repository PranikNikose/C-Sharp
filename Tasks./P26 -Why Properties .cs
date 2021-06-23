using System;

public class Student
{
    private int _id;
    private string _Name;
    private int _Passmark;

    public int GetPasssMark()
    {
        _Passmark = 35;
        return this._Passmark;
    }
    public void SetName(string Name)
    {
        this._Name = Name;
        if (string.IsNullOrWhiteSpace(Name))
            throw new Exception("Name cannot be valid");
        this._Name = Name;
    }
    public string GetName()
    {
        if (string.IsNullOrEmpty(this._Name))
            return "No Name";
        else
            return this._Name;
    }
    public void SetID(int ID)
    {
        this._id = ID;
        if (this._id <= 0)
            throw new Exception("Enter Valid ID ,Id Cannot be negative");
    }
    public int GetID()
    {
        return this._id;
    }
}
class Program
{
    static void Main()
    {
        var c1 = new Student();
        c1.SetID(101);
        c1.SetName("Pkn");
        Console.WriteLine(c1.GetID());
        Console.WriteLine(c1.GetName());
        Console.WriteLine(c1.GetPasssMark());
    }

}
