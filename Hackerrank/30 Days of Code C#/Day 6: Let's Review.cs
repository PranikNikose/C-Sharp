using System;
using System.Collections.Generic;
using System.IO;
class Solution
 {
    static void Main(String[] args) 
    {
        
        int Count = Convert.ToInt32(Console.ReadLine());
        
       
        for(int i=0;i<Count;i++)
        {
            string str = Console.ReadLine().ToString();
            
            for(int j=0;j<str.Length;j++)
            {
            if(j%2==0)
            {
                Console.Write(str[j]);
            }
            }
            Console.Write(" ");
            for(int j=0;j<str.Length;j++)
            {
            if(j%2==1)
            {
                Console.Write(str[j]);
            }
            }
            Console.WriteLine();
        }
    }
}
