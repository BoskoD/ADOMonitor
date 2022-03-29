using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOReleases
{
        internal class Links
        {
            [JsonProperty("avatar")]
            public Avatar Avatar { get; set; }

            [JsonProperty("self")]
            public Self Self { get; set; }

            [JsonProperty("web")]
            public Web Web { get; set; }
        }
}