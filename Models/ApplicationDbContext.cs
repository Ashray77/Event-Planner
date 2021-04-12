using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Venue> VenueTable { get; set; }
        public DbSet<UserAccount> UserTable { get; set; }
        public DbSet<Design> DesignTable { get; set; }

        public DbSet<Menu> MenuTable { get; set; }
    }
}
