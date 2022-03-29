using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ADOMonitor.Models.ADOReleases
{
        internal class ReleaseProperties
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("createdOn")]
            public DateTime CreatedOn { get; set; }

            [JsonProperty("modifiedOn")]
            public DateTime ModifiedOn { get; set; }

            [JsonProperty("modifiedBy")]
            public ModifiedBy ModifiedBy { get; set; }

            [JsonProperty("createdBy")]
            public CreatedBy CreatedBy { get; set; }

            [JsonProperty("createdFor")]
            public CreatedFor CreatedFor { get; set; }

            [JsonProperty("variables")]
            public Variables Variables { get; set; }

            [JsonProperty("variableGroups")]
            public List<object> VariableGroups { get; set; }

            [JsonProperty("releaseDefinition")]
            public ReleaseDefinition ReleaseDefinition { get; set; }

            [JsonProperty("releaseDefinitionRevision")]
            public int ReleaseDefinitionRevision { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("reason")]
            public string Reason { get; set; }

            [JsonProperty("releaseNameFormat")]
            public string ReleaseNameFormat { get; set; }

            [JsonProperty("keepForever")]
            public bool KeepForever { get; set; }

            [JsonProperty("definitionSnapshotRevision")]
            public int DefinitionSnapshotRevision { get; set; }

            [JsonProperty("logsContainerUrl")]
            public string LogsContainerUrl { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("_links")]
            public Links Links { get; set; }

            [JsonProperty("tags")]
            public List<object> Tags { get; set; }

            [JsonProperty("triggeringArtifactAlias")]
            public object TriggeringArtifactAlias { get; set; }

            [JsonProperty("projectReference")]
            public ProjectReference ProjectReference { get; set; }

            [JsonProperty("properties")]
            public Properties Properties { get; set; }
    }
}
