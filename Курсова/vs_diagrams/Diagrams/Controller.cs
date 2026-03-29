using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
    public class Controller
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;
        public bool IsOnline { get; set; }

        public Guid HomeId { get; set; }
        public Home? Home { get; set; }

        public List<Device> Devices { get; set; } = new();
    }
}