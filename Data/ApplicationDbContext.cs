using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppTaxi2026.Models;

namespace WebAppTaxi2026.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //One IdentityUser One -> Driver
            base.OnModelCreating(builder);
            builder.Entity<Driver>()
            .HasIndex(d => d.UserId)
            .IsUnique();
            builder.Entity<Driver>()
            .HasOne(d => d.User)
            .WithOne()
            .HasForeignKey<Driver>(d => d.UserId)
            .OnDelete(DeleteBehavior.Cascade);
            //Seed data from Driver
            

            var user1 = new IdentityUser
            {
                Id = "driver-user-1",
                UserName = "driver1@taxi.com",
                NormalizedUserName = "DRIVER1@TAXI.COM",
                Email = "driver1@taxi.com",
                NormalizedEmail = "DRIVER1@TAXI.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            

            var user2 = new IdentityUser
            {
                Id = "driver-user-2",
                UserName = "driver2@taxi.com",
                NormalizedUserName = "DRIVER2@TAXI.COM",
                Email = "driver2@taxi.com",
                NormalizedEmail = "DRIVER2@TAXI.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
           
            //Seed data from two Drivers
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        }
        public virtual DbSet<Driver> Drivers { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<TaxService> TaxServices { get; set; } = null!;
    }
}
