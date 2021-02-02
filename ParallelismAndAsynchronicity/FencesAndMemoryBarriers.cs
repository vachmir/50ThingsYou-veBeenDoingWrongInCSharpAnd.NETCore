using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParallelismAndAsynchronicity
{
    class FencesAndMemoryBarriers
    {
        static volatile int x, y, a, b;
        public static void Test1()
        {
            x = 1;
            Interlocked.MemoryBarrierProcessWide();
            a = y;
        }

       public static void Test2()
        {
            y = 1;
            Interlocked.MemoryBarrier();
            b = x;
        }
    }
}
