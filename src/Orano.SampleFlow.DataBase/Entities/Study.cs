using Microsoft.EntityFrameworkCore;

namespace Orano.SampleFlow.DataBase.Entities
{
    public class Study
    {
        public int Id { get; set; }
        public int DestinationId { get; set; }
        public int StudyNumber { get; set; }
        public int SurveyCount { get; set; }
        public int SampleCount { get; set; }
        public string? AnalyseTypes { get; set; }
        public Destination Destination { get; set; }
        public IEnumerable<SampleHistorisation> SampleHistorisations { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Study>().HasMany(p => p.SampleHistorisations).WithOne(p => p.Study).OnDelete(DeleteBehavior.NoAction); ;
            modelBuilder.Entity<Dispatch>().HasOne(p => p.Destination);
        }
    }
}
