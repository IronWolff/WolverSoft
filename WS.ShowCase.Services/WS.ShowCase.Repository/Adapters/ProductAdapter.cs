using System.Collections.Generic;
using System.Linq;
using WS.ShowCase.Model;

namespace WS.ShowCase.Repository
{
    public static class ProductAdapter
    {
        public static Product GetModelObject(DataAccess.Product product)
        {
            return new Product
            {
                CategoryId = product.CategoryId,
                BrandId = product.BrandId,
                CreatedByUserId = product.CreatedByUserId,
                CreatedDate = product.CreatedDate,
                Description = product.Description,
                IsActive = product.IsActive,
                ModifiedByUserId = product.ModifiedByUserId,
                ModifiedDate = product.ModifiedDate,
                Name = product.Name,
                ProductId = product.ProductId,
                ProviderId = product.ProductId
            };
        }

        public static DataAccess.Product GetDAObject(Product product)
        {
            return new DataAccess.Product
            {
                CategoryId = product.CategoryId,
                BrandId = product.BrandId,
                CreatedByUserId = product.CreatedByUserId,
                CreatedDate = product.CreatedDate,
                Description = product.Description,
                IsActive = product.IsActive,
                ModifiedByUserId = product.ModifiedByUserId,
                ModifiedDate = product.ModifiedDate,
                Name = product.Name,
                ProductId = product.ProductId,
                ProviderId = product.ProductId
            };
        }

        public static List<Product> GetModelObjectList(List<DataAccess.Product> products)
        {
            return products.Select(product => GetModelObject(product)).ToList();
        }

        public static List<DataAccess.Product> GetDAModelList(List<Product> products)
        {
            return products.Select(product => GetDAObject(product)).ToList();
        }
    }
}
