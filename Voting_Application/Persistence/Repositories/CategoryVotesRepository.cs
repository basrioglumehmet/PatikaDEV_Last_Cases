using System;
using System.Collections.Generic;
using System.Linq;
using Voting_Application.Core.Entities;
using Voting_Application.Core.Interfaces;

namespace Voting_Application.Persistence.Repositories
{
    internal class CategoryVotesRepository : IRepository<CategoryVotes>
    {
        private List<CategoryVotes> categoryVotesList = new List<CategoryVotes>();

        public CategoryVotes Create(CategoryVotes entity)
        {
            entity.Id = Guid.NewGuid();
            categoryVotesList.Add(entity);
            return entity;
        }

        public CategoryVotes Delete(Guid id)
        {
            var categoryVotes = categoryVotesList.SingleOrDefault(cv => cv.Id == id);
            if (categoryVotes != null)
            {
                categoryVotesList.Remove(categoryVotes);
            }
            return categoryVotes;
        }

        public IQueryable<CategoryVotes> GetAll()
        {
            return categoryVotesList.AsQueryable(); ;
        }

        public CategoryVotes GetById(Guid id)
        {
            return categoryVotesList.SingleOrDefault(cv => cv.Id == id);
        }

        public CategoryVotes Update(CategoryVotes entity)
        {
            var categoryVotes = categoryVotesList.SingleOrDefault(cv => cv.Id == entity.Id);
            if (categoryVotes != null)
            {
                categoryVotes.Category_Id = entity.Category_Id;
                categoryVotes.User_Id = entity.User_Id;
                categoryVotes.Rating = entity.Rating;
            }
            return categoryVotes;
        }
    }
}
