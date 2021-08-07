using System;

public class Exercise14
{
    public static void Main()
    {
        Console.WriteLine("Enter the Degree Celsius:");
        int celsius = Convert.ToInt32(Console.ReadLine());
        float kelvin = celsius + 273.15f;
        int faranheit= (celsius * 9 / 5) +32;

        Console.WriteLine();
        Console.WriteLine("Celsius : " + celsius + "°C");
        Console.WriteLine("Kelvin : " + kelvin + "K");
        Console.WriteLine("Faranheit : " + faranheit + "°F");
        Console.WriteLine();
    }
}
