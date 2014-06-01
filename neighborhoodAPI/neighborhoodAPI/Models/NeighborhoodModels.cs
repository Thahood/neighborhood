using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace neighborhoodAPI.Models
{
    
    public class ServiceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ActivityType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Activity
    {
        public int Id { get; set; }
        public virtual ActivityType ActivityType { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class Service
    {
        public int Id { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}