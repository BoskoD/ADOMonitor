using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    internal class Links
    {
        [JsonProperty("self")]
        public Self Self { get; set; }

        [JsonProperty("web")]
        public Web Web { get; set; }

        [JsonProperty("sourceVersionDisplayUri")]
        public SourceVersionDisplayUri SourceVersionDisplayUri { get; set; }

        [JsonProperty("timeline")]
        public Timeline Timeline { get; set; }

        [JsonProperty("badge")]
        public Badge Badge { get; set; }

        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }
    }
}