using Microsoft.EntityFrameworkCore;
using SkateCompScoreboard.Persistence.Data;

namespace API.Extentions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", builder =>

                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader()
                );
            });

            return services;
        }


        public static IServiceCollection ConfigureSQLConnection(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<DataContext>(opt => {

                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            });

            return services;
        }
    }
}
