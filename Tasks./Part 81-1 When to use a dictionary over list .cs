using System;
using System.Collections.Generic;

public class program
{
    static void Main()
    {
        Country country1 = new Country { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
        Country country2 = new Country { Code = "MH", Name = "Maharastra", Capital = "Mumbai" };

        List<Country> listCountries = new List<Country>();
        listCountries.Add(country1);
        listCountries.Add(country2);
        string UserDecision;
        do
        {
            Console.WriteLine("Enter a code");
            string USerCode = Console.ReadLine().ToUpper();

            Country rsltCountry = listCountries.Find(cnttry => cnttry.Code == USerCode);

            if (rsltCountry == null)
            {
                Console.WriteLine("Enter valid Code");
            }
            else
            {
                Console.WriteLine("Name= {0} & Capital ={1}", rsltCountry.Name, rsltCountry.Capital);
            }
            do
            {
                Console.WriteLine("Do Yo want to Continue - YES or NO");
                UserDecision = Console.ReadLine().ToUpper();
            }
            while (UserDecision != "YES" && UserDecision != "NO");
        }
        while (UserDecision == "YES");
    }
}
public class Country
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Capital { get; set; }
}
