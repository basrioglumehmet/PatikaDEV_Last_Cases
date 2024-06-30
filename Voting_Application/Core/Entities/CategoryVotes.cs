using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_Application.Core.Interfaces;

namespace Voting_Application.Core.Entities
{
    internal class CategoryVotes : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid Category_Id { get; set; }
        public Guid User_Id { get; set; }
        public double Rating { get; set; } = 0.0;

    }
}
