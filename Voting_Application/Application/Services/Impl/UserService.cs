using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_Application.Core.Entities;
using Voting_Application.Core.Interfaces;
using Voting_Application.Persistence.Repositories;

namespace Voting_Application.Application.Services.Impl
{
    internal class UserService : IUserService
    {

        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Create(User user)
        {
            return _userRepository.Create(user);
        }

        public void DeleteUser(User user)
        {
            _userRepository.Delete(user.Id);
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetAll().Where(entity => entity.Email == email).SingleOrDefault();
        }

        public User GetUserById(Guid userId)
        {
            return _userRepository.GetAll().Where(entity => entity.Id == userId).SingleOrDefault();
        }

        public User UpdateUser(User user)
        {
            return _userRepository.Update(user);
        }

        public bool CheckUserExists(User user)
        {
            return _userRepository.GetAll().Where(x => x.Email == user.Email).Any();
        }
    }
}
