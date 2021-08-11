using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        //Console.WriteLine("Meal Cost : "+meal_cost);

        double total_cost;

        double tip = (tip_percent * meal_cost) / 100;
        //Console.WriteLine("tip : " + tip);

        double tax = (tax_percent* meal_cost) / 100;
        //Console.WriteLine("tax : " + tax);

        total_cost = meal_cost+ tip + tax;
        Console.WriteLine(Convert.ToInt32(total_cost));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}
