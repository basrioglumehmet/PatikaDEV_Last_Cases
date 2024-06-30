using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_Application.Core.Entities;

namespace Voting_Application.Application.Services
{
    internal interface ICategoryVoteService
    {
        public CategoryVotes Create(CategoryVotes categoryVote);
        public IQueryable<CategoryVotes> ReadAll();
        public CategoryVotes Update(CategoryVotes categoryVote);
        public CategoryVotes Delete(CategoryVotes categoryVote);
        public CategoryVotes GetById(Guid id);
    }
}
