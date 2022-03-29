using System.Collections.Generic;

namespace ADOMonitor.Models.ADOBuilds
{
    internal class BuildRoot
    {
        public int Count { get; set; }
        public List<BuildProperies> Value { get; set; }
    }
}