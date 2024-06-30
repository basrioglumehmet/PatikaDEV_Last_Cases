using System;
using System.Collections.Generic;
using System.Linq;
using Voting_Application.Core.Entities;
using Voting_Application.Core.Interfaces;

namespace Voting_Application.Persistence.Repositories
{
    internal class UserRepository : IRepository<User>
    {
        private List<User> users = new List<User>();

        public User Create(User entity)
        {
            entity.Id = Guid.NewGuid();
            users.Add(entity);
            return entity;
        }

        public User Delete(Guid id)
        {
            var user = users.SingleOrDefault(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
            }
            return user;
        }

        public IQueryable<User> GetAll()
        {
            return users.AsQueryable();
        }

        public User GetById(Guid id)
        {
            return users.SingleOrDefault(u => u.Id == id);
        }

        public User Update(User entity)
        {
            var user = users.SingleOrDefault(u => u.Id == entity.Id);
            if (user != null)
            {
                user.Email = entity.Email;
                user.Password = entity.Password;
            }
            return user;
        }
    }
}
