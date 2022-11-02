using Microsoft.EntityFrameworkCore;

namespace Orano.SampleFlow.DataBase.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string? Label { get; set; }
        public IEnumerable<Affiliate> Affiliates { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasMany(p => p.Affiliates).WithOne(p => p.Country).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
