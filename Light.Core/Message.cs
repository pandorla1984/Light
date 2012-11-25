using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Light.Core
{
    /// <summary>
    /// Single Message
    /// </summary>
    public class Message
    {
        /// <summary>
        /// MessageType
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// MessageParams
        /// </summary>
        public object[] Params { get; set; }

        /// <summary>
        /// Message Content
        /// </summary>
        public string Content { get; set; }
    }
}
