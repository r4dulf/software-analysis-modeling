using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
    public class EventLog
    {
        public Guid Id { get; set; }
        public string EventType { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public Guid HomeId { get; set; }
        public Home? Home { get; set; }
    }
}