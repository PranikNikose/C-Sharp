using System;

namespace FunPurpose
{
    public class TelecomOperator
    {
       private string _MobileNumber;

        public void SetMobNo(string Number)
        {
            this._MobileNumber = Number;
        }

        public string GetMobNo()
        {
            return this._MobileNumber;
        }
    }



    class Program
    {
        static void Main()
        {
            var person1 = new TelecomOperator();
            person1.SetMobNo("7058187989");
            Console.WriteLine("Get No is : {0} ",person1.GetMobNo()); 
        }
    }
}
