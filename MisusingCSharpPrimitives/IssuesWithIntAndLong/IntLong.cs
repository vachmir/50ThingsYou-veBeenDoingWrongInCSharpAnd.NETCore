using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace MisusingCSharpPrimitives.IssuesWithIntAndLong
{
    
    class IntLong
    {
        public static int x;
        public static long y;



        public static void DoWorkIntWrong()
        {
            x++;
        }

        public static void DoWorkInt()
        {
            Interlocked.Add(ref x, 222);
        }

        public static void DoWorkLong()
        {
            Interlocked.Add(ref y, 555);
        }
        
    }
}
