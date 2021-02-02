using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParallelismAndAsynchronicity
{
    class ThreadOverusing
    {
       public static void PrintTime()
        {
            while (true)
            {
                Thread.Sleep(50);
                Console.WriteLine(DateTime.Now);

            }
        }
    }
}
