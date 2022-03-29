using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    internal class TriggerInfo
    {
        [JsonProperty("pr.number")]
        public string PrNumber { get; set; }
    }
}