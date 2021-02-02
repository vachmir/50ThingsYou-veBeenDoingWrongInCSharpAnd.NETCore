using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.SOLID
{
    interface IBetterMessageSenderWithReceipt
    {
        bool GetReadReceipt(int messageId);
    }
}
