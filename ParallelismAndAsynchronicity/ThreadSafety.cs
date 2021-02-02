using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelismAndAsynchronicity
{
    
    class ThreadSafety
    {
       private static object locker = new object();
        static List<int> l = new List<int>();
       

        public static void Loop() 
        {
            ThreadSafety threadSafety = new ThreadSafety();
            try
            {
                while (true)
                {
                  lock (locker)    //This is required with Static members
                    {
                        l.Add(1);
                        l.RemoveAt(0);
                    }

                }   
            }
            catch (Exception e)
            {

                Console.WriteLine(e); ;
            }
        }

    }

}
