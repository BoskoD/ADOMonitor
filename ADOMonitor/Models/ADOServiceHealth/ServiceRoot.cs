using System;
using System.Collections.Generic;

namespace ADOMonitor.Models.ADOServiceHealth
{
    internal class ServiceRoot
    {
        public DateTime LastUpdated { get; set; }
        public ServiceStatus Status { get; set; }
        public List<Service> Services { get; set; }
    }
}