using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tickets.Infrastructure.Persistence;
using Tickets.Infrastructure.Seeders;

namespace Tickets.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("TicketsDb");
            services.AddScoped<IUserSeeder, UserSeeder>();
            services.AddDbContext<TicketsDBContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
