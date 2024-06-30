using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_Application.Core.Interfaces;

namespace Voting_Application.Core.Entities
{
    internal class User : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
