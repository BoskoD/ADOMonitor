using System.Collections.Generic;

namespace ADOMonitor.Models.ADOServiceHealth
{
    internal class Service
    {
        public string Id { get; set; }
        public List<Geography> Geographies { get; set; }
    }
}