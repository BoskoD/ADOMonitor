﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace ADOMonitor.Models.ADOBuilds
{
    internal class Definition
    {
        [JsonProperty("drafts")]
        public List<object> Drafts { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("queueStatus")]
        public string QueueStatus { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }
    }
}