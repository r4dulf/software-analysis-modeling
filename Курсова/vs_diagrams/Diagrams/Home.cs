using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
   
    public class Home
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public List<Room> Rooms { get; set; } = new();
        public List<Controller> Controllers { get; set; } = new();
        public List<Scenario> Scenarios { get; set; } = new();
        public List<EventLog> EventLogs { get; set; } = new();
    }

}