using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MisusingCSharpPrimitives.MisusingStructsAndBoxingMistakes
{
    class Structs
    {
        public static void Struct()
        {
            int i = 5;
            var o = (object)i; //Boxing, function stack value type is moved to heap

            var s = 5;
            var o2 = (object)s; //Casting
            int? j = 5;
            Console.WriteLine(j.GetType().Name);

            var roe = new ReadOnlyEnumerator(new List<int> { 1, 2 });
            roe.PrintTheFirstElement();
        }
    }
}
