using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
    public class Trigger
    {
        public Guid Id { get; set; }
        public TriggerType Type { get; set; }
        public string ParametersJson { get; set; } = string.Empty;

        public Guid ScenarioId { get; set; }
        public Scenario? Scenario { get; set; }
    }
}