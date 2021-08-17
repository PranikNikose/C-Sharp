using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) 
    {
        Dictionary<string, string> Phonebook = new Dictionary<string, string>();
        int entries = Convert.ToInt32(Console.ReadLine());
        
        for (int i=0;i<entries;i++)
        {
            string[] contact = Console.ReadLine().Split(' ');
            Phonebook[contact[0]] = contact[1];
        }    
        
        string searchName;
        while((searchName=Console.ReadLine())!=null)
        {
            if (Phonebook.ContainsKey(searchName))
            {
                Console.WriteLine(searchName+"="+Phonebook[searchName]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
