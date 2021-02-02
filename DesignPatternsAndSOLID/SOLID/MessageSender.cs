using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.SOLID
{
    class MessageSender
    {
        /// <summary>
        /// This satisfies Dependency inversion principle of separate implementation,
        /// but violates Open — Closed principle, because public data field can be changed externally
        /// </summary>


        public MessageSender(string targetAddrss) => this.TargetAddress = targetAddrss;

        //Should be hidden
        //Should not be public
        public string TargetAddress;

        //Must be Virtual or Abstract
        public void SendConfirmationMessage(string message)
        {
            //Send email
        }
    }
}
