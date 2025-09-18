using Tickets.Domain.Entities.User;
using Tickets.Domain.Enums;
using Tickets.Infrastructure.Persistence;

namespace Tickets.Infrastructure.Seeders
{
    internal class UserSeeder(TicketsDBContext dBContext) : IUserSeeder
    {
        public async Task Seed()
        {
            if (await dBContext.Database.CanConnectAsync())
            {
                if (!dBContext.Users.Any())
                {
                    var users = GetUsers();
                    dBContext.Users.AddRange(users);
                    await dBContext.SaveChangesAsync();
                }
            }
        }

        private IEnumerable<User> GetUsers()
        {
            List<User> users = new List<User>
            {
                new User("Gabriel França", "gabriel.franca@intrabank.com.br", UserRole.Agent),
                new User("Gabriel Lobo", "gabriel.lobo@intrabank.com.br", UserRole.Admin),
                new User("Bruno de Paula", "bruno.paula@intrabank.com.br", UserRole.Requester)
            };

            return users;
        }
    }
}
