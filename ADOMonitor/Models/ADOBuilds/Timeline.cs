using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    public class Timeline
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
