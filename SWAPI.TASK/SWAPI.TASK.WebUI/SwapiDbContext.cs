using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWAPI.TASK.WebUI
{
    public class SwapiDbContext : DbContext, ISwapiDbContext
    {
        public SwapiDbContext(DbContextOptions<SwapiDbContext> options)
            : base(options)
        {

        }

        public DbSet<UserReview> UserReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SwapiDbContext).Assembly);

        }
    }
}
