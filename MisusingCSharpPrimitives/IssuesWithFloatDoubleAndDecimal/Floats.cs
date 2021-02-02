using System;
using System.Collections.Generic;
using System.Text;

namespace MisusingCSharpPrimitives.IssuesWithFloatDoubleAndDecimal
{
    class Floats
    {
        static public void Types()
        {
            var f = 10f;
            var d = 20d;
            var money = 50M;
            Console.WriteLine(0.3 * 3.0 + 0.1 == 1.0);
            Console.WriteLine(0.3M * 3.0M + 0.1M == 1.0M);

            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(money);
        }
    }
}
