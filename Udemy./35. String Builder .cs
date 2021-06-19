using System;
using System.Text;
namespace StringBuilderNS
{
    public class StringBuilderClass
    {
        static void Main()
        {
            var builder = new StringBuilder();
            builder.Append('-', 15);
            builder.AppendLine();
            builder.Append("Hello Pranik");
            builder.AppendLine();
            builder.Append('-', 15);

            builder.Replace('-', '+');
            builder.Remove(0, 15);
            builder.Insert(0, "+", 15);

            Console.WriteLine(builder);
            Console.WriteLine("First Char :"+ builder[0]);
        }
    }
}

