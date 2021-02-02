using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.Singleton
{
    class SingletonLazy
    {
        static Lazy<SingletonLazy> lazy = new Lazy<SingletonLazy>(() => new SingletonLazy());
        static readonly object locker = new object();

        private SingletonLazy() { }

        //Only one instance is created
        public static SingletonLazy Instance => lazy.Value;

    }
}
