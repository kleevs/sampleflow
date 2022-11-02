using Microsoft.EntityFrameworkCore;
using Orano.SampleFlow.Authentification;

namespace Orano.SampleFlow.DataBase.Entities
{
    public class Sample
    {
        public int Id { get; set; }
        public int BatchId { get; set; }
        public int? OriginSampleId { get; set; }
        public bool IsReceived { get; set; }
        public string? SampleNumber { get; set; }
        public string? FieldNumber { get; set; }
        public Batch Batch { get; set; }
        public Sample OriginSample { get; set; }
        public IEnumerable<SampleHistorisation> SampleHistorisations { get; set; }
        public IEnumerable<Sample> SampleChildren { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sample>().HasOne(p => p.Batch).WithMany(p => p.Samples);
            modelBuilder.Entity<Sample>().HasOne(p => p.OriginSample).WithMany(p => p.SampleChildren).OnDelete(DeleteBehavior.NoAction).HasForeignKey(p => p.OriginSampleId);
            modelBuilder.Entity<Sample>().HasMany(p => p.SampleChildren).WithOne(p => p.OriginSample).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Sample>().HasMany(p => p.SampleHistorisations).WithOne(p => p.Sample).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
