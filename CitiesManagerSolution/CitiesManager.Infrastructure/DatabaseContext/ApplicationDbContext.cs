using CitiesManager.Core.Identity;
using CitiesManager.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.Infrastructure.DatabaseContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public ApplicationDbContext()
        {
            
        }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = Guid.Parse("72246112-F307-47BF-B69E-C8ECDB10C5D8"),
                CityName = "NewYork"
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = Guid.Parse("7924810C-2796-4A2A-A0B3-4854DF6DAC5A"),
                CityName = "London"

            });
        }
    }
}
