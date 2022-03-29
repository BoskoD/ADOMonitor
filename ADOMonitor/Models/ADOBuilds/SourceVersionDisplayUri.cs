using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    public class SourceVersionDisplayUri
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}