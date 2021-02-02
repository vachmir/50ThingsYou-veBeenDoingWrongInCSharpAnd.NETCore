using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.DesignPatternsUsage
{
    class Process : IProcess
    {
        public void DoWork()
        {
            Console.WriteLine("Do Work");
        }
    }
}
