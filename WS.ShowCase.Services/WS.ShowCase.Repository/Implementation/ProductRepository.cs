using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.ShowCase.Exceptions;
using WS.ShowCase.Model;
using Brand = WS.ShowCase.Model.Brand;
using Category = WS.ShowCase.Model.Category;
using Product = WS.ShowCase.Model.Product;
using Provider = WS.ShowCase.Model.Provider;

namespace WS.ShowCase.Repository
{
    public partial class ShowCaseRepository : IShowCaseRepository
    {
#region Validations
        private void ValidateBrand(Brand brand, bool isUpdate = false)
        {
            if(isUpdate)
            {
                ValidateBrandExists(brand.BrandId);
            }

            ValidateUserExists(brand.CreatedByUserId);

            if(brand.ModifiedByUserId.GetValueOrDefault() > 0)
            {
                ValidateUserExists(brand.ModifiedByUserId.Value);
            }
        }

        private void ValidateBrandExists(int brandId)
        {
            DataAccess.Brand brandDA = ShowCaseDataContext.Brands.SingleOrDefault(b => b.BrandId == brandId);

            if (brandDA == null)
            {
                throw new BrandDoesNotExistsException(string.Format("Brand with Id '{0}' does not exist",
                                                                    brandId));
            }
        }

        private void ValidateUserExists(int userId)
        {
            DataAccess.User userDA = ShowCaseDataContext.Users.SingleOrDefault(user => user.UserId == userId);

            if(userDA == null)
            {
                throw new UserDoesNotExistsException(string.Format("User with Id '{0}' does not exist", userId));
            }
        }

        private void ValidateCategory(Category category, bool isUpdate = false)
        {
            if(isUpdate)
            {
                ValidateCategoryExists(category.CategoryId);
            }

            if(category.ModifiedByUserId.GetValueOrDefault() > 0)
            {
                ValidateUserExists(category.ModifiedByUserId.Value);
            }
        }

        private void ValidateCategoryExists(int categoryId)
        {
            DataAccess.Category categoryDA = ShowCaseDataContext.Categories.SingleOrDefault(c => c.CategoryId == categoryId);

            if (categoryDA == null)
            {
                throw new CategoryDoesNotExistsException(string.Format("Category with Id '{0}' does not exist", categoryId));
            }
        }

        private void ValidateProduct(Product product, bool isUpdate = false)
        {
            if(isUpdate)
            {
                ValidateProductExists(product.ProductId);
            }
            
            if(product.BrandId > 0)
            {
                ValidateBrandExists(product.BrandId);
            }

            if(product.CategoryId > 0)
            {
                ValidateCategoryExists(product.CategoryId);
            }

            if(product.CreatedByUserId > 0)
            {
                ValidateUserExists(product.CreatedByUserId);
            }

            if(product.ModifiedByUserId.GetValueOrDefault() > 0)
            {
                ValidateUserExists(product.ModifiedByUserId.Value);
            }

            if(product.ProviderId > 0)
            {
                ValidateProviderExists(product.ProviderId);
            }
        }

        private void ValidateProductExists(int productId)
        {
            DataAccess.Product productDA = ShowCaseDataContext.Products.SingleOrDefault(p => p.ProductId == productId);

            if(productDA == null)
            {
                throw new ProductDoesNotExistsException(string.Format("Product with Id '{0}' does not exist", productId));
            }
        }

        private void ValidateProviderExists(int providerId)
        {
            DataAccess.Provider providerDA =
                ShowCaseDataContext.Providers.SingleOrDefault(p => p.ProviderId == providerId);

            if(providerDA == null)
            {
                throw new ProviderDoesNotExistsException(string.Format("Provider with Id '{0}' does not exist", providerId));
            }
        }

        private void ValidateProvider(Provider provider, bool isUpdate = false)
        {
            if(isUpdate)
            {
                ValidateProviderExists(provider.ProviderId);
            }

            if(provider.CreatedByUserId > 0)
            {
                ValidateUserExists(provider.CreatedByUserId);
            }

            if(provider.ModifiedByUserId.GetValueOrDefault() > 0)
            {
                ValidateUserExists(provider.ModifiedByUserId.Value);
            }
        }

        #endregion Validations

#region Brands
        public int InsertBrand(Brand brand)
        {
            ValidateBrand(brand);
            brand.CreatedDate = DateTime.Now;
            DataAccess.Brand brandDA = BrandAdapter.GetDAObject(brand);
            ShowCaseDataContext.Brands.AddObject(brandDA);
            SaveChanges();
            return brandDA.BrandId;
        }

        public void UpdateBrand(Brand brand)
        {
            ValidateBrand(brand, true);

            DataAccess.Brand brandDA = ShowCaseDataContext.Brands.SingleOrDefault(b => b.BrandId == brand.BrandId);

            brandDA.Description = brand.Description;
            brandDA.IsActive = brand.IsActive;
            brandDA.ModifiedByUserId = brand.ModifiedByUserId;
            brandDA.ModifiedDate = DateTime.Now;
            brandDA.Name = brand.Name;
        }

        public List<Model.Brand> GetFilteredBrands(BrandFilter filter)
        {
            IQueryable<DataAccess.Brand> brandsDA = ShowCaseDataContext.Brands.AsQueryable();

            if (filter.BrandId > 0)
            {
                brandsDA = brandsDA.Where(b => b.BrandId == filter.BrandId);
            }
            else
            {
                if(filter.CreatedByUserId > 0)
                {
                    brandsDA = brandsDA.Where(b => b.CreatedByUserId == filter.CreatedByUserId);
                }

                if(filter.ModifiedByUserId > 0)
                {
                    brandsDA = brandsDA.Where(b => b.ModifiedByUserId == filter.ModifiedByUserId);
                }

                if(!string.IsNullOrWhiteSpace(filter.Name))
                {
                    brandsDA = brandsDA.Where(b => string.Compare(b.Name, filter.Name, true) == 0);
                }

                if(!string.IsNullOrWhiteSpace(filter.Description))
                {
                    brandsDA = brandsDA.Where(b => string.Compare(b.Description, filter.Description, true) == 0);
                }
            }

            if(brandsDA.Count() > 0)
            {
                return BrandAdapter.GetModelObjectList(brandsDA.ToList());
            }

            return null;
        }

#endregion Brands

#region Categories
        public int InsertCategory(Category category)
        {
            ValidateCategory(category);

            DataAccess.Category categoryDA =
                ShowCaseDataContext.Categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);

            ShowCaseDataContext.Categories.AddObject(categoryDA);
            SaveChanges();
            return categoryDA.CategoryId;
        }

        public void UpdateCategory(Category category)
        {
            ValidateCategory(category, true);

            DataAccess.Category categoryDA =
                ShowCaseDataContext.Categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);

            categoryDA.Description = category.Description;
            categoryDA.ModifiedByUserId = category.ModifiedByUserId;
            categoryDA.ModifiedDate = DateTime.Now;
            categoryDA.Name = category.Name;
        }

        public List<Model.Category> GetFilteredCategories(CategoryFilter filter)
        {
            IQueryable<DataAccess.Category> categoriesDA = ShowCaseDataContext.Categories.AsQueryable();

            if(filter.CategoryId > 0)
            {
                categoriesDA = categoriesDA.Where(c => c.CategoryId == filter.CategoryId);
            }
            else
            {
                if(!string.IsNullOrWhiteSpace(filter.Name))
                {
                    categoriesDA = categoriesDA.Where(c => string.Compare(c.Name, filter.Name, true) == 0);
                }

                if(!string.IsNullOrWhiteSpace(filter.Description))
                {
                    categoriesDA = categoriesDA.Where(c => string.Compare(c.Description, filter.Description, true) == 0);
                }

                if(filter.CreatedByUserId > 0)
                {
                    categoriesDA = categoriesDA.Where(c => c.CreatedByUserId == filter.CreatedByUserId);
                }
            }

            if(categoriesDA.Count() > 0)
            {
                return CategoryAdapter.GetModelObjectList(categoriesDA.ToList());
            }

            return null;
        }

#endregion Categories

#region Products

        public int InsertProduct(Product product)
        {
            ValidateProduct(product, false);

            DataAccess.Product productDA = ProductAdapter.GetDAObject(product);

            ShowCaseDataContext.Products.AddObject(productDA);
            SaveChanges();
            return productDA.ProductId;
        }

        public void UpdateProduct(Product product)
        {
            ValidateProduct(product, true);

            DataAccess.Product productDA =
                ShowCaseDataContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productDA.BrandId = product.BrandId;
            productDA.CategoryId = product.CategoryId;
            productDA.Description = product.Description;
            productDA.Name = product.Name;
            productDA.ProviderId = product.ProviderId;
            productDA.ModifiedByUserId = product.ModifiedByUserId;
            productDA.ModifiedDate = DateTime.Now;
        }

        public List<Model.Product> GetFilteredProducts(ProductFilter filter)
        {
            IQueryable<DataAccess.Product> productsDA = ShowCaseDataContext.Products.AsQueryable();

            if(filter.ProductId > 0)
            {
                productsDA = productsDA.Where(p => p.ProductId == filter.ProductId);
            }
            else
            {
                if(filter.BrandId > 0)
                {
                    productsDA = productsDA.Where(p => p.BrandId == filter.BrandId);
                }

                if(filter.CategoryId > 0)
                {
                    productsDA = productsDA.Where(p => p.CategoryId == filter.CategoryId);
                }

                if(!string.IsNullOrWhiteSpace(filter.Description))
                {
                    productsDA = productsDA.Where(p => string.Compare(p.Description, filter.Description, true) == 0);
                }

                if(!string.IsNullOrWhiteSpace(filter.Name))
                {
                    productsDA = productsDA.Where(p => string.Compare(p.Name, filter.Description, true) == 0);
                }

                if(filter.ProviderId > 0)
                {
                    productsDA = productsDA.Where(p => p.ProviderId == filter.ProviderId);
                }
            }

            if(productsDA.Count() > 0)
            {
                return ProductAdapter.GetModelObjectList(productsDA.ToList());
            }

            return null;
        }

#endregion Products

#region Providers
        public int InsertProvider(Provider provider)
        {
            ValidateProvider(provider);

            DataAccess.Provider providerDA = ProviderAdapter.GetDAModel(provider);
            ShowCaseDataContext.Providers.AddObject(providerDA);
            SaveChanges();
            return providerDA.ProviderId;
        }

        public void UpdateProvider(Provider provider)
        {
            ValidateProvider(provider, true);

            DataAccess.Provider providerDA =
                ShowCaseDataContext.Providers.SingleOrDefault(p => p.ProviderId == provider.ProviderId);

            providerDA.Address1 = provider.Address1;
            providerDA.Address2 = provider.Address2;
            providerDA.Description = provider.Description;
            providerDA.Name = provider.Name;
            providerDA.Email = provider.Email;
            providerDA.IsActive = provider.IsActive;
            providerDA.ModifiedByUserId = provider.ModifiedByUserId;
            providerDA.ModifiedDate = DateTime.Now;
            providerDA.OwnerFirstName = provider.OwnerFirstName;
            providerDA.OwnerLastName = provider.OwnerLastName;
            providerDA.Phone = provider.Phone;
            providerDA.Zip = provider.Zip;
        }

        public List<Model.Provider> GetFilteredProviders(ProviderFilter filter)
        {
            IQueryable<DataAccess.Provider> providersDA = ShowCaseDataContext.Providers.AsQueryable();
            
            if(filter.ProviderId > 0)
            {
                providersDA = providersDA.Where(p => p.ProviderId == filter.ProviderId);
            }
            else
            {
                if(!string.IsNullOrWhiteSpace(filter.Name))
                {
                    providersDA = providersDA.Where(p => string.Compare(p.Name, filter.Name, true) == 0);
                }

                if(!string.IsNullOrWhiteSpace(filter.Description))
                {
                    providersDA = providersDA.Where(p => string.Compare(p.Description, filter.Description, true) == 0);
                }

                if(!string.IsNullOrWhiteSpace(filter.OwnerFirstName))
                {
                    providersDA =
                        providersDA.Where(p => string.Compare(p.OwnerFirstName, filter.OwnerFirstName, true) == 0);
                }

                if(!string.IsNullOrWhiteSpace(filter.OwnerLastName))
                {
                    providersDA =
                        providersDA.Where(p => string.Compare(p.OwnerLastName, filter.OwnerLastName, true) == 0);
                }

                if(!string.IsNullOrWhiteSpace(filter.Zip))
                {
                    providersDA = providersDA.Where(p => string.Compare(p.Zip, filter.Zip, true) == 0);
                }

                if(!string.IsNullOrWhiteSpace(filter.Address1))
                {
                    providersDA = providersDA.Where(p => string.Compare(p.Address1, filter.Address1, true) == 0);
                }

                if (!string.IsNullOrWhiteSpace(filter.Address2))
                {
                    providersDA = providersDA.Where(p => string.Compare(p.Address2, filter.Address2, true) == 0);
                }
            }

            if(providersDA.Count() > 0)
            {
                return ProviderAdapter.GetModelObjectList(providersDA.ToList());
            }

            return null;
        }
#endregion Providers
    }
}
