using Microsoft.Extensions.DependencyInjection;

namespace Orano.SampleFlow.DataBase.Configurations
{
    public static class SampleFlowServiceCollectionExtensions
    {
        public static IServiceCollection AddSampleFlowDbContext(this IServiceCollection services)
        {
            services.AddDbContext<SampleFlowDbContext>();
            return services;
        }
    }
}
