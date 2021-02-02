using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.Singleton
{
    class Singleton3
    {
        static Singleton3 instance;
        static readonly object locker = new object();

        private Singleton3() { }

        public static Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        instance = new Singleton3();
                    }
                }
                return instance;
            }
        }
    }
}
