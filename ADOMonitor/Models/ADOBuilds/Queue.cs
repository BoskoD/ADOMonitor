using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    internal class Queue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pool")]
        public Pool Pool { get; set; }
    }
}