using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.DesignPatternsUsage
{
    class LoggingProcess : IProcess
    {
        readonly IProcess process;
        public LoggingProcess(IProcess process) => this.process = process;

        public void DoWork()
        {
            Console.WriteLine("Before dowork");
            this.process.DoWork();
            Console.WriteLine("After dowork");
        }
    }
    
    
}
