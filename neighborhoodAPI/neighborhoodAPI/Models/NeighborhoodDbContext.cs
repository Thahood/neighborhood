using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace neighborhoodAPI.Models
{
    public class NeighborhoodDbContext:ApplicationDbContext
    {
       
        public NeighborhoodDbContext() : base()
        {
            
        }

        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ActivityType> ActivityTypes{ get; set; }
        public DbSet<Activity> Activities { get; set; }

    }
}