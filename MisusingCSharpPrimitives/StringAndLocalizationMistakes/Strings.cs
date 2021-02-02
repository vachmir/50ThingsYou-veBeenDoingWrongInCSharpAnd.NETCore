using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MisusingCSharpPrimitives.StringAndLocalizationMistakes
{
    class Strings
    {
        public static void String()
        {
            Console.WriteLine("Enter double value");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(++d);

            var myDouble = "5,84";
            var turkishCulture = CultureInfo.GetCultureInfo("tr-TR");
            Console.WriteLine(Double.Parse(myDouble, CultureInfo.InvariantCulture));
            Console.WriteLine(Double.Parse(myDouble, turkishCulture));

            var description = "Description";

            Console.WriteLine(description.ToUpper() == "DESCRIPTION"); //true
            Console.WriteLine(description.ToUpper().Equals("DESCRIPTION")); //true
            Console.WriteLine(object.ReferenceEquals(description.ToUpper(), "DESCRIPTION")); //false4


            Thread.CurrentThread.CurrentCulture = turkishCulture;
            Console.WriteLine(description.ToUpper() == "DEScRIPTION"); //false DESCRIPTION
            Console.WriteLine(description.ToUpperInvariant() == "DESCRIPTION"); //true

            Console.WriteLine(description.Equals("DESCRIPTION", StringComparison.OrdinalIgnoreCase)); //TRUE

            var dt = "05/01/12";
            Console.WriteLine(DateTime.Parse(dt).ToLongDateString());
            Console.WriteLine(DateTime.Parse(dt).ToString("dddd, MMMM dd yyyy"));
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(DateTime.Parse(dt).ToString("dddd, MMMM dd yyyy"));
            //Console.WriteLine(DateTime.ParseExact(dt, "MM/dd/yyyy", turkishCulture).ToString("dddd, MMMM dd yyyy"));
            Console.WriteLine("_____________________________________________________________________");
        }
    }
}
