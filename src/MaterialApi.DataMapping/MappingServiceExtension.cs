using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MaterialApi.DataMapping
{
    public static class MappingServiceExtension
    {
        public static void AddMapper(this IServiceCollection services)
        {
            // Get profiles
            var mapperConfig = new MapperConfiguration(config =>
            {
                typeof(WorkerMap)
                .Assembly.GetTypes()
                .Where(_ => typeof(Profile).IsAssignableFrom(_))
                .ToList()
                .ForEach(p => config.AddProfile(p));
            });

            // Into service collection
            services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}
