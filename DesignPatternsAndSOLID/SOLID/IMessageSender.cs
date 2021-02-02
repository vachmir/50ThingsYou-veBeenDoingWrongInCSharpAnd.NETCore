using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.SOLID
{
    interface IMessageSender
    {
        /// <summary>
        /// Violates Interface Segregation Principle by having universal Interface
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        int SendConfirmationMessage(string message);

        //ReadReceipt is not supported by all implementors
        bool GetReadReceipment(int messageId);

    }
}
