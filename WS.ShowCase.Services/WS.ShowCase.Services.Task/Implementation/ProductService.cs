using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.ShowCase.Model;

namespace WS.ShowCase.Services.Task
{
    class ProductService : ShowCaseServiceBase, IProductService
    {
#region Validations

        private void ValidateBrand(Brand brand, bool isUpdate = false)
        {
            if(brand == null)
            {
                throw new ArgumentNullException("brand", "brand is required");
            }

            if(brand.CreatedByUserId < 1)
            {
                throw new ArgumentNullException("CreatedByUserId", "brand is required");
            }

            if (string.IsNullOrWhiteSpace(brand.Name))
            {
                throw new ArgumentNullException("Name", "Name is required");
            }

            if (string.IsNullOrWhiteSpace(brand.Description))
            {
                throw new ArgumentNullException("Description", "Description is required");
            }

            if(isUpdate)
            {
                if(brand.BrandId < 1)
                {
                    throw new ArgumentNullException("brandId", "brand is required");
                }
            }
        }

        private void ValidateCategory(Category category, bool isUpdate = false)
        {
            if(category == null)
            {
                throw new ArgumentNullException("category", "category is required");
            }

            if(category.CreatedByUserId < 1)
            {
                throw new ArgumentNullException("CreatedByUserId", "CreatedByUserId is required");
            }

            if(string.IsNullOrWhiteSpace(category.Name))
            {
                throw new ArgumentNullException("Name", "Name is required");
            }

            if(string.IsNullOrWhiteSpace(category.Description))
            {
                throw new ArgumentNullException("Description", "Description is required");
            }

            if(isUpdate)
            {
                if(category.ModifiedByUserId < 1)
                {
                    throw new ArgumentNullException("ModifiedByUserId", "ModifiedByUserId is required");
                }
            }
        }

        private void ValidateProduct(Product product, bool isUpdate = false)
        {
            if(product == null)
            {
                throw new ArgumentNullException("product", "product is required");
            }

            if(product.BrandId < 1)
            {
                throw new ArgumentNullException("BrandId", "BrandId is required");
            }

            if (product.CategoryId < 1)
            {
                throw new ArgumentNullException("CategoryId", "CategoryId is required");
            }

            if (product.CreatedByUserId < 1)
            {
                throw new ArgumentNullException("CreatedByUserId", "CreatedByUserId is required");
            }

            if (product.ProviderId < 1)
            {
                throw new ArgumentNullException("ProviderId", "ProviderId is required");
            }

            if(string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ArgumentNullException("Name", "Name is required");
            }

            if (string.IsNullOrWhiteSpace(product.Description))
            {
                throw new ArgumentNullException("Description", "Description is required");
            }

            if(isUpdate)
            {
                if(product.ProductId < 1)
                {
                    throw new ArgumentNullException("ProductId", "ProductId is required");
                }
            }
        }

        private void ValidateProvider(Provider provider, bool isUpdate = false)
        {
            if(provider == null)
            {
                throw new ArgumentNullException("provider", "provider is required");
            }

            if(provider.CreatedByUserId < 1)
            {
                throw new ArgumentNullException("CreatedByUserId", "CreatedByUserId is required");
            }

            if(string.IsNullOrWhiteSpace(provider.Name))
            {
                throw new ArgumentNullException("Name", "Name is required");
            }

            if (string.IsNullOrWhiteSpace(provider.Description))
            {
                throw new ArgumentNullException("Description", "Description is required");
            }

            if (string.IsNullOrWhiteSpace(provider.Email))
            {
                throw new ArgumentNullException("Email", "Email is required");
            }

            if (string.IsNullOrWhiteSpace(provider.Phone))
            {
                throw new ArgumentNullException("Phone", "Phone is required");
            }

            if (string.IsNullOrWhiteSpace(provider.OwnerFirstName))
            {
                throw new ArgumentNullException("OwnerFirstName", "OwnerFirstName is required");
            }

            if (string.IsNullOrWhiteSpace(provider.OwnerLastName))
            {
                throw new ArgumentNullException("OwnerLastName", "OwnerLastName is required");
            }

            if(isUpdate)
            {
                if(provider.ProviderId < 1)
                {
                    throw new ArgumentNullException("ProviderId", "ProviderId is required");
                }
            }
        }

        #endregion Validations

#region Brands
        public int InsertBrand(Brand brand)
        {
            try
            {
                ValidateBrand(brand);
                return _showCaseRepository.InsertBrand(brand);
            }
            catch(Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

        public void UpdateBrand(Brand brand)
        {
            try
            {
                ValidateBrand(brand, true);
                _showCaseRepository.UpdateBrand(brand);
                _showCaseRepository.SaveChanges();
            }
            catch(Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

        public List<Model.Brand> GetFilteredBrands(BrandFilter filter)
        {
            try
            {
                if(filter == null)
                {
                    throw new ArgumentNullException("filter", "filter is required");
                }

                return _showCaseRepository.GetFilteredBrands(filter);
            }
            catch(Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

#endregion Brands

#region Categories
        public int InsertCategory(Category category)
        {
            try
            {
                ValidateCategory(category);
                return _showCaseRepository.InsertCategory(category);
            }
            catch(Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                ValidateCategory(category, true);
                _showCaseRepository.UpdateCategory(category);
                _showCaseRepository.SaveChanges();
            }
            catch(Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

        public List<Model.Category> GetFilteredCategories(CategoryFilter filter)
        {
            try
            {
                if(filter == null)
                {
                    throw new ArgumentNullException("filter", "filter is required");
                }
                return _showCaseRepository.GetFilteredCategories(filter);
            }
            catch(Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

#endregion Products

#region Products
        public int InsertProduct(Product product)
        {
            try
            {
                ValidateProduct(product);
                return _showCaseRepository.InsertProduct(product);
            }
            catch (Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                ValidateProduct(product, true);
                _showCaseRepository.UpdateProduct(product);
                _showCaseRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

        public List<Model.Product> GetFilteredProducts(ProductFilter filter)
        {
            try
            {
                if (filter == null)
                {
                    throw new ArgumentNullException("filter", "filter is required");
                }
                return _showCaseRepository.GetFilteredProducts(filter);
            }
            catch (Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

#endregion Products

#region Providers
        public int InsertProvider(Provider provider)
        {
            try
            {
                ValidateProvider(provider);
                return _showCaseRepository.InsertProvider(provider);
            }
            catch (Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

        public void UpdateProvider(Provider provider)
        {
            try
            {
                ValidateProvider(provider, true);
                _showCaseRepository.UpdateProvider(provider);
                _showCaseRepository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw GetFaultException(ex);
            }
        }

        public List<Model.Provider> GetFilteredProviders(ProviderFilter filter)
        {
            try
            {
                if (filter == null)
                {
                    throw new ArgumentNullException("filter", "filter is required");
                }
                return _showCaseRepository.GetFilteredProviders(filter);
            }
            catch (Exception ex)
            {
                throw GetFaultException(ex);
            }
        }
#endregion Providers
    }
}
