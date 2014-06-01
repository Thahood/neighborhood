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
    }
}