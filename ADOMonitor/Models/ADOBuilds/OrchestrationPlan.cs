using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    internal class OrchestrationPlan
    {
        [JsonProperty("planId")]
        public string PlanId { get; set; }
    }
}
