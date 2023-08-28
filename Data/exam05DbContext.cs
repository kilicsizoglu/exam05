using exam05.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace exam05.Data
{
    public class exam05DbContext : DbContext
    {

        public exam05DbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {



        }

        public DbSet<Walk> walks { get; set; }

        public DbSet<Region> regions { get; set; }

        public DbSet<Difficulty> difficulties { get; set; }

        
    }
}
