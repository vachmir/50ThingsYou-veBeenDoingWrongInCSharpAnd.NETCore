using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.SOLID
{
    interface IBetterMessageSender
    {
        int SendConfirmationMessage(string message);
    }
}
