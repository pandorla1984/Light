using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Core.Events
{
    public class LightEvent
    {
        public LightEventCategory Category { get; set; }
        public LightEventLevel Level { get; set; }
        public string Key { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
