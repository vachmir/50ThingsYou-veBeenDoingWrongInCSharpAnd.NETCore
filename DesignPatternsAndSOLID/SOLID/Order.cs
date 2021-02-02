using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSOLID.SOLID
{
    class Order
    {

        //Violates Single Responsiblity and Dependency Inversion Principles

        //High level Order class must not depend on implementation of low level action — Dependency Inversion
        // So, SendConfirmationMessage method should be implemented in separete class, for exampple in MessageSender class
        public void SendConfirmationMessage(string message)
        {
            //Send email
        }
    }
}
