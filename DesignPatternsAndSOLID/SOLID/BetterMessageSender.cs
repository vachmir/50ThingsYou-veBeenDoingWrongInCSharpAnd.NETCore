using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSOLID.SOLID
{
    class BetterMessageSender
    {
        public BetterMessageSender(string targetAddress) => this.targetAddress = targetAddress;

        protected readonly string targetAddress;

        //Must be Virtual or Abstract
        public virtual void SendConfirmationMessage(string mesage)
        {

            if (mesage.Length > 500) throw new ArgumentException("Message too long ");
            //Send emal
        }
    }
}
