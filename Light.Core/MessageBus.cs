using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Light.Core
{
    /// <summary>
    /// MessageBus for all messages
    /// </summary>
    public class MessageBus : Stack<Message>
    {
        /// <summary>
        /// Message receivers
        /// </summary>
        public List<IMessageReceiver> Receivers { get; set; }

        /// <summary>
        /// Construct a MessageBus
        /// </summary>
        public MessageBus()
        {
            if (Receivers == null)
            {
                Receivers = new List<IMessageReceiver>();
            }           
        }

        /// <summary>
        /// Run the message bus
        /// </summary>
        public void Run()
        {
            Timer watcher = new Timer((obj) =>
            {
                if (this.Peek() != null)
                {
                    var theMessage = this.Pop();
                    var theResult = Receivers.Where(r => r.GetAcceptableMessageTypes().Contains(theMessage.Type) || theMessage.Type == CONSTS.MESSAGE_TYPE_ALL)
                        .Select<IMessageReceiver, Message>(r => r.ProcessMessage(theMessage));
                }
            }, null, 0, 100);
        }
    }
}
