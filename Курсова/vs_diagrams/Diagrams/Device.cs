using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
    public class Device
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public DeviceStatus Status { get; set; }
        public bool IsEnabled { get; set; }

        public Guid RoomId { get; set; }
        public Room? Room { get; set; }

        public Guid ControllerId { get; set; }
        public Controller? Controller { get; set; }

        public List<Sensor> Sensors { get; set; } = new();
    }
}