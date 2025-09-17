using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Enums;
using Tickets.Domain.Primitives;

namespace Tickets.Domain.Entities.User
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public UserRole role { get; private set; }
    }
}
