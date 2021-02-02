using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResolvingGeneralCSharpCodingErrors.HandlingExceptionsCorrectly
{
    class Exceptions
    {
        public static void DoShopping(Product p)
        {
            CalculateTax(p);
        }

        static void CalculateTax(Product p)
        {

            var previousPrice = p.Price;
            p.Price += 1M;
            var taxIncrease = (p.Price - previousPrice) / previousPrice;
            Console.WriteLine($"Price increase {taxIncrease.ToString("P")}");

            //try
            //{
            //    var previousPrice = p.Price;
            //    p.Price += 1M;
            //    var taxIncrease = (p.Price - previousPrice) / previousPrice;
            //    Console.WriteLine($"Price increase {taxIncrease.ToString("P")}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
        }
    }
}
