using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
    public class Sensor
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public double Value { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid DeviceId { get; set; }
        public Device? Device { get; set; }
    }
}