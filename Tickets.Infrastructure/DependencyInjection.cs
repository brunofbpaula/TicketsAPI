using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tickets.Infrastructure.Persistence;

namespace Tickets.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("TicketsDb");

            return services.AddDbContext<TicketsDBContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
