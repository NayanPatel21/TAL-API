using System;
using Microsoft.EntityFrameworkCore;
using TAL.DAL.Configuration;

namespace TAL.DAL.Models
{
    public class TALDBContext : DbContext
    {
        public TALDBContext(DbContextOptions<TALDBContext> options) : base(options)
        {

        }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<OccupationRating> OccupationRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OccupationRatingConfiguration());
            modelBuilder.ApplyConfiguration(new OccupationConfiguration());
        }
    }
}
