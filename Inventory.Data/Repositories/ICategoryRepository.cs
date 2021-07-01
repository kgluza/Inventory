using Inventory.Data.Dto;
using System.Collections.Generic;

namespace Inventory.Data
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories(string id = null, string name = null);

        Category GetCategoryById(int categoryId);

        void AddCategory(Category category);

        void DeleteCategory(int categoryId);

        void UpdateCategory(Category category);
    }
}
