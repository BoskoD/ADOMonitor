using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    internal class Badge
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}