using Newtonsoft.Json;
using System.Collections.Generic;

namespace ADOMonitor.Models.ADOReleases
{
    internal class ReleaseRoot
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public List<ReleaseProperties> Value { get; set; }
    }
}