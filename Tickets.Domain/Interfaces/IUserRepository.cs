using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Entities.User;

namespace Tickets.Domain.Interfaces
{
    internal interface IUserRepository
    {
        User GetUser(int id);
    }
}
