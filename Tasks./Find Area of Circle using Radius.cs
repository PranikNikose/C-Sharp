using System;
class Circle
{
    static float pi;
    int radius;

    //Staic Constructor
    static Circle()
    {
       Circle.pi = 3.141f;
    }

    //Instance Constructor
    public Circle(int R)
    {
        this.radius = R;
    }

    //Method
    public float CalculateArea()
    {
        return Circle.pi * this.radius * this.radius;
    }

    //Main Method
    static void Main()
    {
        var c1 = new Circle(5);
        float result = c1.CalculateArea();
        Console.WriteLine("Radius of: {0}",result);

    }

}
