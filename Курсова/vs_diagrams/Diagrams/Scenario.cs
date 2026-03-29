using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
    public class Scenario
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public Guid HomeId { get; set; }
        public Home? Home { get; set; }

        public Trigger? Trigger { get; set; }
        public List<Action> Actions { get; set; } = new();
    }
}