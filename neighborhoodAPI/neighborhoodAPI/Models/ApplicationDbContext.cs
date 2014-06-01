using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace neighborhoodAPI.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
 
        public ApplicationDbContext()
            : base("DataConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}