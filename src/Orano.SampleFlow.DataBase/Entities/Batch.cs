using Microsoft.EntityFrameworkCore;

namespace Orano.SampleFlow.DataBase.Entities
{
    public class Batch
    {
        public int Id { get; set; }
        public int SectorId { get; set; }
        public string? FieldNumber { get; set; }
        public string? BatchNumber { get; set; }
        public int SurveyCount { get; set; }
        public int SampleCount { get; set; }
        public DateTime ExpeditionDate { get; set; }
        public DateTime ReceptionDate { get; set; }
        public int Weight { get; set; }
        public int Gamma { get; set; }
        public string? Manager { get; set; }

        public Sector Sector { get; set; }
        public IEnumerable<Sample> Samples { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Batch>().HasOne(p => p.Sector);
            modelBuilder.Entity<Batch>().HasMany(p => p.Samples).WithOne(p => p.Batch).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
