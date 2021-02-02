using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.Singleton
{
   public sealed class Singleton2
    {
        static Singleton2 instance;
        static readonly object locker = new object();

        private Singleton2() { }

        public static Singleton2 Instance
        {
            get
            {
                lock (locker)
                {
                    instance = instance ?? new Singleton2();
                    return instance;
                }
            }
        }
    }
}
