using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
    
    public Difference(int[] a)
    {
        this.elements = a;
    }
    
    public int computeDifference()
    {
        int max = elements[0];
        int min = elements[0];

        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] > max)
            {
                max = elements[i];
            }

            if (elements[i] < min)
            {
                min = elements[i];
            }
        }
        maximumDifference = Math.Abs(max - min); 
        return maximumDifference;
    }
} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}
