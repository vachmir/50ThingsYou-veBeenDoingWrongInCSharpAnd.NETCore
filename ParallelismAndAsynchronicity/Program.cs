using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelismAndAsynchronicity
{
    class Program
    {
        static volatile int x, y, a, b;
        static void Main(string[] args)
        {
            #region Overusing Thread
            //Task.Run(ThreadOverusing.PrintTime);   //Creating background Tread;
            //Console.WriteLine("a");

            //for (; ; )        //We must make Thread to continue his job by using infinite loop
            //{
            //    Console.WriteLine("A");
            //}
            ////Console.ReadKey();
            #endregion



            #region Pay Attention on Thread Safety
            //Task.Run(ThreadSafety.Loop);
            //Task.Run(ThreadSafety.Loop);
            //Console.ReadKey();
            #endregion



            #region Fences and Memory Barriers
            //while (true)
            //{
            //    var t1 = Task.Run(FencesAndMemoryBarriers.Test1);
            //    var t2 = Task.Run(FencesAndMemoryBarriers.Test2);
            //    Task.WaitAll(t1, t2);
            //    if (a==0&&b==0)
            //    {
            //        Console.WriteLine($"{a}, {b}");
            //    }
            //    x = y = a = b = 0;
            //}
            #endregion
        }



    }
}

