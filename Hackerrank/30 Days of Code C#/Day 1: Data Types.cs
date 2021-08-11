using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        
        // Declare second integer, double, and String variables.
        int k;
        double dd;
        string str;
        
        // Read and save an integer, double, and String to your variables.
        k =  Convert.ToInt32(Console.ReadLine());
        dd = Convert.ToDouble(Console.ReadLine());
        str = Convert.ToString( Console.ReadLine());
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i+k);
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine((d + dd).ToString("F1"));
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + ""+ str);
    }
}
