using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    public class Plan
    {
        [JsonProperty("planId")]
        public string PlanId { get; set; }
    }
}
