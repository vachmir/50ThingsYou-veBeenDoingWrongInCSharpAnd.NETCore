using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.DesignPatternsUsage
{
    class Client
    {
        public void StartProcess()
        {
            this.CreateProcess().DoWork();
        }

        protected virtual IProcess CreateProcess()
        {
            return new Process();
        }
    }
}
