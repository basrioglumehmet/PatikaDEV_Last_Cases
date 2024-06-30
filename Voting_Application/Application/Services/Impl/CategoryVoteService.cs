using System;
using System.Linq;
using Voting_Application.Core.Entities;
using Voting_Application.Core.Interfaces;
using Voting_Application.Persistence.Repositories;

namespace Voting_Application.Application.Services.Impl
{
    internal class CategoryVoteService : ICategoryVoteService
    {
        private readonly CategoryVotesRepository _repository;

        public CategoryVoteService()
        {
            _repository = new CategoryVotesRepository();
        }

        public CategoryVotes Create(CategoryVotes categoryVote)
        {
            return _repository.Create(categoryVote);
        }

        public CategoryVotes Delete(CategoryVotes categoryVote)
        {
            return _repository.Delete(categoryVote.Id);
        }

        public CategoryVotes GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<CategoryVotes> ReadAll()
        {
            return _repository.GetAll();
        }

        public CategoryVotes GetVoteByCategoryId(Guid categoryId)
        {
            return _repository.GetAll().FirstOrDefault(v => v.Category_Id == categoryId);
        }

        public double GetAverageRatingForCategory(Guid categoryId)
        {
            var votes = _repository.GetAll().Where(v => v.Category_Id == categoryId);
            if (votes.Any())
            {
                return votes.Average(v => v.Rating);
            }
            return 0.0;
        }

        public CategoryVotes Update(CategoryVotes categoryVote)
        {
            return _repository.Update(categoryVote);
        }
    }
}
