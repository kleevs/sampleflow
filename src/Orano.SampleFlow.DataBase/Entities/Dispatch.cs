using Microsoft.EntityFrameworkCore;

namespace Orano.SampleFlow.DataBase.Entities
{
    public class Dispatch
    {
        public int Id { get; set; }
        public int DestinationId { get; set; }
        public int DispatchNumber { get; set; }
        public string? Receiver { get; set; }
        public string? Sender { get; set; }
        public int SampleCount { get; set; }
        public DateTime ExpeditionDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int Weight { get; set; }
        public int Gamma { get; set; }
        public string? Attachment { get; set; }
        public Destination Destination { get; set; }
        public IEnumerable<SampleHistorisation> SampleHistorisations { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dispatch>().HasMany(p => p.SampleHistorisations).WithOne(p => p.Dispatch).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Dispatch>().HasOne(p => p.Destination);
        }
    }
}
