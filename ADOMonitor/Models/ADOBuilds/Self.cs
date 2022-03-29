using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    public class Self
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}