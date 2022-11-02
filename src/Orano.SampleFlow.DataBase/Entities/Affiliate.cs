using Microsoft.EntityFrameworkCore;

namespace Orano.SampleFlow.DataBase.Entities
{
    public class Affiliate
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string? Label { get; set; }
        public Country Country { get; set; }
        public IEnumerable<Sector> Sectors { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Affiliate>().HasOne(p => p.Country).WithMany(p => p.Affiliates);
            modelBuilder.Entity<Affiliate>().HasMany(p => p.Sectors).WithOne(p => p.Affiliate).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
