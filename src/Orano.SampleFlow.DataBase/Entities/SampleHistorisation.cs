using Microsoft.EntityFrameworkCore;

namespace Orano.SampleFlow.DataBase.Entities
{
    public class SampleHistorisation
    {
        public int Id { get; set; }
        public int SampleId { get; set; }
        public int DispatchId { get; set; }
        public int StockageId { get; set; }
        public int StudyId { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public int Gamma { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Sample Sample { get; set; }
        public Dispatch Dispatch { get; set; }
        public Stockage Stockage { get; set; }
        public Study Study { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SampleHistorisation>().HasOne(p => p.Sample).WithMany(p => p.SampleHistorisations);
            modelBuilder.Entity<SampleHistorisation>().HasOne(p => p.Dispatch).WithMany(p => p.SampleHistorisations);
            modelBuilder.Entity<SampleHistorisation>().HasOne(p => p.Stockage).WithMany(p => p.SampleHistorisations);
            modelBuilder.Entity<SampleHistorisation>().HasOne(p => p.Study).WithMany(p => p.SampleHistorisations);
        }
    }
}
