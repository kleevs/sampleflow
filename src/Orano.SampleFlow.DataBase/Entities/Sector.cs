using Microsoft.EntityFrameworkCore;

namespace Orano.SampleFlow.DataBase.Entities
{
    public class Sector
    {
        public int Id { get; set; }
        public int AffiliateId { get; set; }
        public string? Label { get; set; }
        public Affiliate Affiliate { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sector>().HasOne(p => p.Affiliate);
        }
    }
}
