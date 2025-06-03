using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language.Message.Spanish
{
    public class MessageInSpanish : Interface.IMessage
    {
        public string Description
        {
            get { return "Spanish"; }
        }

        public string Message
        {
            get { return "Hola"; }
        }
    }
}
