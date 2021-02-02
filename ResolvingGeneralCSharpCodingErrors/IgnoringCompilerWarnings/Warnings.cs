using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolvingGeneralCSharpCodingErrors.IgnoringCompilerWarnings
{
    static class Warnings
    {
        public static void User()
        {
            string firstName;
            string lastName;


            firstName = Console.ReadLine();
            Console.WriteLine("Your name is " + firstName);

        }
    }
}
