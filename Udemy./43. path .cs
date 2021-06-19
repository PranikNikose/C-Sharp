using System;
using System.Collections.Generic;
using System.IO;
namespace pathNS
{
    public class pathClass
    {
        static void Main()
        {
            var location = @"D:\CODEMBS\Pranik Thesis\Condition 1\No Accident Position.png";

            Console.WriteLine("Directory Name: "+ Path.GetDirectoryName(location));
            Console.WriteLine("File Name: " + Path.GetFileName(location));
            Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(location));
            Console.WriteLine("Extension: " + Path.GetExtension(location));
        }
    }
}

