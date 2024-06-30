using System;
using System.Linq;
using Voting_Application.Core.Entities;
using Voting_Application.Core.Providers;
using Voting_Application.Core.Providers.Impl;
using Voting_Application.Persistence.Repositories;

namespace Voting_Application.Application.Services.Impl
{
    internal class CategoryService : ICategoryService
    {
        private readonly CategoryRepository _repository;
        private readonly CategoryVoteService _voteService;

        public CategoryService()
        {
            _repository = new CategoryRepository();
            _voteService = new CategoryVoteService();
        }

        public Category CreateCategory(Category category)
        {
            return _repository.Create(category);
        }

        public Category DeleteCategory(Guid id)
        {
            return _repository.Delete(id);
        }

        public IQueryable<Category> GetAllCategories()
        {
            return _repository.GetAll();
        }

        public Category GetCategoryById(Guid id)
        {
            return _repository.GetById(id);
        }

        public Category GetCategoryByName(string name)
        {
            return _repository.GetAll().FirstOrDefault(x => x.Name == name);
        }

        public void ListCategoriesSelection()
        {
            var categories = _repository.GetAll().ToList();
            if (categories.Any())
            {
                if (SessionProvider.CurrentUser == null)
                {
                    Console.WriteLine("Misafir kullanıcıların kategorilere oy verme izni yoktur.");
                    Console.WriteLine("Kayıt veya giriş işlemleri için 0'a basmanız gerekmektedir.\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Puan vermek istediğiniz kategoriyi seçiniz (Numara) ile gösterilen tuşa basmanız yeterli\n");
                }

                ListAllCategories(categories);

                if (SessionProvider.CurrentUser != null)
                {
                    RatingIO();
                }
            }
            else
            {
                Console.WriteLine("Kategori kayıdı eklemeniz gerekmektedir.");
            }
        }

        private void ListAllCategories(IEnumerable<Category> categories)
        {
            int index = 0;
            foreach (var category in categories)
            {
                index++;
                var rating = _voteService.GetAverageRatingForCategory(category.Id);
                Console.WriteLine($"({index}) Kategori: {category.Name} - Puan: {rating}");
            }
        }

        public void RatingIO()
        {
            var key = Console.ReadKey();
            Console.Clear();

            if (int.TryParse(key.KeyChar.ToString(), out int selection))
            {
                var categories = _repository.GetAll().ToList();
                if (selection > 0 && selection <= categories.Count)
                {
                    var category = categories[selection - 1];
                    var vote = _voteService.GetVoteByCategoryId(category.Id);

                    if (vote == null)
                    {
                        vote = new CategoryVotes { Category_Id = category.Id, Rating = 1 };
                        _voteService.Create(vote);
                    }
                    else
                    {
                        vote.Rating++;
                        _voteService.Update(vote);
                    }

                    Console.WriteLine("Oy verildi.");
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen numara giriniz.");
            }
        }


        public Category UpdateCategory(Category category)
        {
            return _repository.Update(category);
        }

        public Category UpdateCategoryByName(string name)
        {
            var categoryEntity = _repository.GetAll().FirstOrDefault(x => x.Name == name);
            return categoryEntity != null ? _repository.Update(categoryEntity) : null;
        }
    }
}
