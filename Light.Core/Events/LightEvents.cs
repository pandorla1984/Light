using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Core.Events
{
    public static class LightEvents
    {
        #region Fields
        /// <summary>
        /// Static event collection
        /// </summary>
        public static List<LightEvent> Events;

        #endregion

        #region Events
        delegate void EventsChangedHandler(LightEvent ev);
        /// <summary>
        /// Will be fired when a event is published
        /// </summary>
        public static event EventsChangedHandler EventsChanged; 
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        static LightEvents()
        {
            Events = new List<LightEvent>();
        }

        #region Methods

        /// <summary>
        /// publish a light event
        /// </summary>
        /// <param name="category">LightEventCategory</param>
        /// <param name="level">LightEventLevel</param>
        /// <param name="eventKey">Event key</param>
        /// <param name="eventContent">Event content</param>
        /// <param name="timeStamp">Event UTC time</param>
        public void Publish(LightEventCategory category, LightEventLevel level, string eventKey, string eventContent, DateTime timeStamp)
        {
            if (timeStamp.Kind != DateTimeKind.Utc)
            {
                Publish(LightEventCategory.Infrastructure, LightEventLevel.Warning, "EV0002", "Event trying to be published must have a UTC timestamp.", DateTime.UtcNow);
                return;
            }

            Publish(new LightEvent { Category = category, Level = level, Key = eventKey, Content = eventContent, TimeStamp = timeStamp });
        }

        /// <summary>
        /// Publish a light event
        /// </summary>
        /// <param name="ev">LightEvent</param>
        public void Publish(LightEvent ev)
        {
            if (ev == null)
            {
                Publish(LightEventCategory.Infrastructure, LightEventLevel.Warning, "EV0001", "Event trying to be published is null", DateTime.UtcNow);
                return;
            }

            if (ev.TimeStamp.Kind != DateTimeKind.Utc)
            {
                Publish(LightEventCategory.Infrastructure, LightEventLevel.Warning, "EV0002", "Event trying to be published must have a UTC timestamp.", DateTime.UtcNow);
                return;
            }

            Events.Add(ev);
            if (EventsChanged != null)
            {
                EventsChanged(ev);
            }
        } 
        #endregion
    }
}
