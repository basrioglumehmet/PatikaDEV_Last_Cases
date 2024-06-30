using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_Application.Core.Entities;

namespace Voting_Application.Application.Services
{
    internal interface IUserService
    {
        public User GetUserById(Guid userId);
        public User GetUserByEmail(string email);
        public User Create(User user);
        public User UpdateUser(User user);
        public void DeleteUser(User user);
        public bool CheckUserExists(User user);
    }
}
