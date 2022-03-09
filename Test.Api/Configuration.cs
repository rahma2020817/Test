using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Test.Infrastructure;

namespace Test.Api
{
    
        public class ConfigurationFactory
        {
            public static void SetUp(IServiceCollection services, ConfigurationManager configuration)
            {
                services.AddDbContext<SchoolDbContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("SchoolDb"));
                });
            }
        }
    
}