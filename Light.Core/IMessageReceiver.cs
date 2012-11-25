using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Light.Core
{
    public interface IMessageReceiver
    {
        List<string> GetAcceptableMessageTypes();
        Message ProcessMessage(Message msg);
    }
}
