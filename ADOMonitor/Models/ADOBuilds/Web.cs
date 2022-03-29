using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    public class Web
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}