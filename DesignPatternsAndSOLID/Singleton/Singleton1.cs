using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.Singleton
{
    class Singleton1
    {
        static Singleton1 instance;

        private Singleton1() { }

        public static Singleton1 Instance
        {
            get => instance = instance ?? new Singleton1();
        }
    }
}
