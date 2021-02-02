using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelismAndAsynchronicity
{
    class Program
    {
        
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



            #region 
            #endregion
        }



    }
}

