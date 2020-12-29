using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MaterialApi.DataAccess
{
    public static class DataAccessExtensions
    {
        public static void AddDataAccess(this IServiceCollection services, string connString, bool development)
        {
            // add DBContext
            services.AddDbContext<MaterialContext>(options =>
            {
                options.UseSqlServer(connString);
                if (development)
                {
                    options.EnableSensitiveDataLogging();
                }
            });

            // register interface to be resolved to MaterialContext
            services.AddScoped<IMaterialContext>(provider => provider.GetService<MaterialContext>());
        }

        public static void InitializedDB(IServiceProvider provider)
        {
            using (var scope = provider.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    using (var context = services.GetService<MaterialContext>())
                    {
                        context.Database.Migrate();
                    }
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<MaterialContext>>();
                    logger.LogError(ex, "An error occured seeding the DB");
                }
            }
        }
    }
}