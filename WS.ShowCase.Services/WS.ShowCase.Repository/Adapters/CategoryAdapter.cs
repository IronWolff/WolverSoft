using System.Collections.Generic;
using System.Linq;
using WS.ShowCase.Model;

namespace WS.ShowCase.Repository
{
    public static class CategoryAdapter
    {
        public static Category GetModelObject(DataAccess.Category category)
        {
            return new Category
            {
                CategoryId = category.CategoryId,
                CreatedByUserId = category.CreatedByUserId,
                CreatedDate = category.CreatedDate,
                Description = category.Description,
                IsActive = category.IsActive,
                ModifiedByUserId = category.ModifiedByUserId,
                ModifiedDate = category.ModifiedDate,
                Name = category.Name
            };
        }

        public static DataAccess.Category GetDAModel(Category category)
        {
            return new DataAccess.Category
            {
                CategoryId = category.CategoryId,
                CreatedByUserId = category.CreatedByUserId,
                CreatedDate = category.CreatedDate,
                Description = category.Description,
                IsActive = category.IsActive,
                ModifiedByUserId = category.ModifiedByUserId,
                ModifiedDate = category.ModifiedDate,
                Name = category.Name
            };
        }

        public static List<Category> GetModelObjectList(List<DataAccess.Category> categories)
        {
            return categories.Select(category => GetModelObject(category)).ToList();
        }

        public static List<DataAccess.Category> GetDAModelList(List<Category> categories)
        {
            return categories.Select(category => GetDAModel(category)).ToList();
        }
    }
}
