using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOReleases
{
        public class ProjectReference
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

}
