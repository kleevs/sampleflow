using Microsoft.EntityFrameworkCore;

namespace Orano.SampleFlow.DataBase.Entities
{
    public class Stockage
    {
        public int Id { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public IEnumerable<SampleHistorisation> SampleHistorisations { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stockage>().HasMany(p => p.SampleHistorisations).WithOne(p => p.Stockage).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
