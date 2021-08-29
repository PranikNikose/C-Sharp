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



class Solution
{
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numArray = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        
       
        int numSwaps = 0;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - 1; j++) {
                if (numArray[j] > numArray[j + 1]) 
                {
                    Array.Reverse(numArray, j, 2);
                    numSwaps++;
                }
            }

            if (numSwaps == 0) {
                break;
            }
        }
        
        Console.WriteLine("Array is sorted in {0} swaps.",numSwaps);
        Console.WriteLine("First Element: {0}",numArray[0]);
        Console.WriteLine("Last Element: {0}",numArray[numArray.Length - 1]);
    }  
}
