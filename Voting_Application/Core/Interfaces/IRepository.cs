using System;
using System.Linq;

namespace Voting_Application.Core.Interfaces
{
    internal interface IRepository<T> where T : IEntity
    {
        T GetById(Guid id);
        IQueryable<T> GetAll();
        T Create(T entity);
        T Update(T entity);
        T Delete(Guid id);
    }
}
