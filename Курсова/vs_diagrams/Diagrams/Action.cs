using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
    public class Action
    {
        public Guid Id { get; set; }
        public ActionType Type { get; set; }
        public string ParametersJson { get; set; } = string.Empty;
        public int OrderIndex { get; set; }

        public Guid ScenarioId { get; set; }
        public Scenario? Scenario { get; set; }
    }
}