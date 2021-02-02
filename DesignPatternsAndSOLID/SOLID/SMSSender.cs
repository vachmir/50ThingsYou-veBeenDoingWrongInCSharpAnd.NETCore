using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.SOLID
{
    class SMSSender : BetterMessageSender
    {
        /// <summary>
        /// Violates Liskov Substitution by using BetterMessageSender instead of SMSSender
        /// </summary>
        /// <param name="targetNumber"></param>
        SMSSender(string targetNumber) : base(targetNumber) { }
        public override void SendConfirmationMessage(string mesage)
        {
            //Violates Liskov Substitution
            if (mesage.Length > 200) throw new ArgumentException("Message too long");
        }
    }
}
