using Newtonsoft.Json;

namespace ADOMonitor.Models.ADOBuilds
{
    internal class Repository
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("clean")]
        public object Clean { get; set; }

        [JsonProperty("checkoutSubmodules")]
        public bool CheckoutSubmodules { get; set; }
    }
}