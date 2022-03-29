using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    public class Pool
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isHosted")]
        public bool IsHosted { get; set; }
    }
}