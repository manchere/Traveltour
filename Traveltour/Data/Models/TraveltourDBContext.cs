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

        public DbSet<User> Users { get; set; }
    }
}