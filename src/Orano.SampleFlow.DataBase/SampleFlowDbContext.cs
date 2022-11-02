using Microsoft.EntityFrameworkCore;
using Orano.SampleFlow.DataBase.Entities;

namespace Orano.SampleFlow.DataBase
{
    public class SampleFlowDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SampleFlow;User Id=sa;Password=34r0TNhvgOde;", (o) => o.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Entities.Affiliate.Configure(modelBuilder);
            Entities.Batch.Configure(modelBuilder);
            Entities.Country.Configure(modelBuilder);
            Entities.Dispatch.Configure(modelBuilder);
            Entities.Sample.Configure(modelBuilder);
            Entities.SampleHistorisation.Configure(modelBuilder);
            Entities.Stockage.Configure(modelBuilder);
        }

        public DbSet<Affiliate> Affiliate { get; set; }
        public DbSet<Batch> Batch { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Dispatch> Dispatch { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<SampleHistorisation> SampleHistorisation { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Stockage> Stockage { get; set; }
        public DbSet<Study> Study { get; set; }
    }
}
