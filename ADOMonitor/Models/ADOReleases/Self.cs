using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOReleases
{
        public class Self
        {
            [JsonProperty("href")]
            public string Href { get; set; }
        }
}
