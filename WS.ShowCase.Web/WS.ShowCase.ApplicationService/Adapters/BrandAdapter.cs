using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.ShowCase.ViewModels;

namespace WS.ShowCase.ApplicationService.Adapters
{
    public static class BrandAdapter
    {
        public static BrandModel GetViewModel(ProductSvc.Brand brand)
        {
            return new BrandModel
            {
                BrandId = brand.BrandId,
                CreatedByUserId = brand.CreatedByUserId,
                CreatedDate = brand.CreatedDate,
                Description = brand.Description,
                IsActive = brand.IsActive,
                ModifiedByUserId = brand.ModifiedByUserId,
                ModifiedDate = brand.ModifiedDate,
                Name = brand.Name
            };
        }

        public static ProductSvc.Brand GetDomainModel(BrandModel brand)
        {
            return new ProductSvc.Brand
            {
                BrandId = brand.BrandId,
                CreatedByUserId = brand.CreatedByUserId,
                CreatedDate = brand.CreatedDate,
                Description = brand.Description,
                IsActive = brand.IsActive,
                ModifiedByUserId = brand.ModifiedByUserId,
                ModifiedDate = brand.ModifiedDate,
                Name = brand.Name
            };
        }

        public static List<BrandModel> GetViewModelList(List<ProductSvc.Brand> brands)
        {
            return brands.Select(brand => GetViewModel(brand)).ToList();
        }

        public static List<ProductSvc.Brand> GetDomainModelList(List<BrandModel> brands)
        {
            return brands.Select(brand => GetDomainModel(brand)).ToList();
        }
    }
}
