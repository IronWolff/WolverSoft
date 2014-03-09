using System.Collections.Generic;
using System.Linq;
using WS.ShowCase.Model;

namespace WS.ShowCase.Repository
{
    public static class BrandAdapter
    {
        public static Brand GetModelObject(DataAccess.Brand brand)
        {
            return new Brand
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

        public static DataAccess.Brand GetDAObject(Brand brand)
        {
            return new DataAccess.Brand
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

        public static List<Brand> GetModelObjectList(List<DataAccess.Brand> brands)
        {
            return brands.Select(brand => GetModelObject(brand)).ToList();
        }

        public static List<DataAccess.Brand> GetDAObjectList(List<Brand> brands)
        {
            return brands.Select(brand => GetDAObject(brand)).ToList();
        }
    }
}
