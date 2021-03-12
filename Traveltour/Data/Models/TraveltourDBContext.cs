using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Traveltour.Data
{
    public class TraveltourDBContext : DbContext
    {
        public TraveltourDBContext(DbContextOptions<TraveltourDBContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.Bookings).WithOne(a => a.User).HasForeignKey(a => a.UserId);

            // modelBuilder.Seed();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Trip> Categories { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}