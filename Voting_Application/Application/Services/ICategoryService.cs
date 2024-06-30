using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_Application.Core.Entities;

namespace Voting_Application.Application.Services
{
    internal interface ICategoryService
    {
        public Category GetCategoryById(Guid id);
        public Category GetCategoryByName(string name);
        public IQueryable<Category> GetAllCategories();
        public Category CreateCategory(Category category);
        public Category UpdateCategory(Category category);
        public Category UpdateCategoryByName(string name);
        public Category DeleteCategory(Guid id);
        public void ListCategoriesSelection();
    }
}
