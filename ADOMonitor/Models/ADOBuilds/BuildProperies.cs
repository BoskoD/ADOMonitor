﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ADOMonitor.Models.ADOBuilds
{
    internal class BuildProperies
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("validationResults")]
        public List<object> ValidationResults { get; set; }

        [JsonProperty("plans")]
        public List<Plan> Plans { get; set; }

        [JsonProperty("triggerInfo")]
        public TriggerInfo TriggerInfo { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("buildNumber")]
        public string BuildNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("queueTime")]
        public DateTime QueueTime { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("definition")]
        public Definition Definition { get; set; }

        [JsonProperty("buildNumberRevision")]
        public int BuildNumberRevision { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("sourceBranch")]
        public string SourceBranch { get; set; }

        [JsonProperty("sourceVersion")]
        public string SourceVersion { get; set; }

        [JsonProperty("queue")]
        public Queue Queue { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("requestedFor")]
        public RequestedFor RequestedFor { get; set; }

        [JsonProperty("requestedBy")]
        public RequestedBy RequestedBy { get; set; }

        [JsonProperty("lastChangedDate")]
        public DateTime LastChangedDate { get; set; }

        [JsonProperty("lastChangedBy")]
        public LastChangedBy LastChangedBy { get; set; }

        [JsonProperty("parameters")]
        public string Parameters { get; set; }

        [JsonProperty("orchestrationPlan")]
        public OrchestrationPlan OrchestrationPlan { get; set; }

        [JsonProperty("logs")]
        public Logs Logs { get; set; }

        [JsonProperty("repository")]
        public Repository Repository { get; set; }

        [JsonProperty("keepForever")]
        public bool KeepForever { get; set; }

        [JsonProperty("retainedByRelease")]
        public bool RetainedByRelease { get; set; }

        [JsonProperty("triggeredByBuild")]
        public object TriggeredByBuild { get; set; }
    }
}