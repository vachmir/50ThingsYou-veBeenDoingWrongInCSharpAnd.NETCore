using System;
using System.Collections.Generic;
using System.Text;

namespace ResolvingGeneralCSharpCodingErrors.MisunderstandingPassbyReference
{
   static  class References
    {
        public static void Greetings()
        {
            var ninjas = new[] { "Itachi", "Kisame", "Naruto" };
            for (var i = 0; i < 3; i++)
            {
                AddGreeting(ref ninjas[i]);        //We must use ref
            }
            foreach (var ninja in ninjas)
            {
                Console.WriteLine(ninja);
            }
        }
        static void AddGreeting(ref string ninja)
            => ninja = "Greetings " + ninja;
    }
}
