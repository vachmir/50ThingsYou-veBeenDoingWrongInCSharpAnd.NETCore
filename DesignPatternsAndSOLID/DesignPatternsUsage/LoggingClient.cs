using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSOLID.DesignPatternsUsage
{
    class LoggingClient:Client
    {
        protected override IProcess CreateProcess()
        {
            return new LoggingProcess(new Process());
        }
    }
}
