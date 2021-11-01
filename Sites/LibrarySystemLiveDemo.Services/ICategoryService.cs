using LibrarySystemLiveDemo.Data.Models;
using System;
using System.Linq;

namespace LibrarySystemLiveDemo.Services
{
    public interface ICategoryService
    {
        IQueryable<Category> GetAllCategoriesWithBooksIncluded();

        IQueryable<Category> GetAllCategoriesSortedById();

        Category GetById(Guid id);

        int InsertCategory(Category category);

        int DeleteCategory(Guid categoryId);

        int UpdateCategory(Category category);
    }
}
