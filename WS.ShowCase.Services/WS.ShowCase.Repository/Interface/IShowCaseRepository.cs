using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.ShowCase.Model;

namespace WS.ShowCase.Repository
{
    public interface IShowCaseRepository : IDisposable
    {
        void SaveChanges();

        int InsertBrand(Brand brand);

        void UpdateBrand(Brand brand);

        List<Brand> GetFilteredBrands(BrandFilter filter);

        int InsertCategory(Category category);

        void UpdateCategory(Category category);

        List<Category> GetFilteredCategories(CategoryFilter filter);

        int InsertProduct(Product product);

        void UpdateProduct(Product product);

        List<Product> GetFilteredProducts(ProductFilter filter);

        int InsertProvider(Provider provider);

        void UpdateProvider(Provider provider);

        List<Provider> GetFilteredProviders(ProviderFilter filter);
    }
}
