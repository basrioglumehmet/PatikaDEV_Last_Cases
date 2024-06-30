using System;
using System.Collections.Generic;
using System.Linq;
using Voting_Application.Core.Entities;
using Voting_Application.Core.Interfaces;

namespace Voting_Application.Persistence.Repositories
{
    internal class CategoryRepository : IRepository<Category>
    {
        private List<Category> categories = new List<Category>();

        public Category Create(Category entity)
        {
            entity.Id = Guid.NewGuid();
            categories.Add(entity);
            return entity;
        }

        public Category Delete(Guid id)
        {
            var category = categories.SingleOrDefault(c => c.Id == id);
            if (category != null)
            {
                categories.Remove(category);
            }
            return category;
        }

        public IQueryable<Category> GetAll()
        {
            return categories.AsQueryable();
        }

        public Category GetById(Guid id)
        {
            return categories.SingleOrDefault(c => c.Id == id);
        }

        public Category Update(Category entity)
        {
            var category = categories.SingleOrDefault(c => c.Id == entity.Id);
            if (category != null)
            {
                category.Name = entity.Name;
            }
            return category;
        }
    }
}
