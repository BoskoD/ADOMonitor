using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOReleases
{
        internal class ReleaseDefinition
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("path")]
            public string Path { get; set; }

            [JsonProperty("projectReference")]
            public object ProjectReference { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("_links")]
            public Links Links { get; set; }
        }
}
