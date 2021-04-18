using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EventPlanner.Models
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<RoleModel> RoleTable { get; set; }
        public DbSet<Venue> VenueTable { get; set; }
        public DbSet<UserAccount> UserTable { get; set; }
        public DbSet<Design> DesignTable { get; set; }
        public DbSet<Menu> MenuTable { get; set; }
        public DbSet<Booking> BookingTable { get; set; }
        public DbSet<EventTypeModel> EventTypeTable { get; set; }
    }
}
