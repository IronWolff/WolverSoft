using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.ShowCase.ApplicationService.Adapters;
using WS.ShowCase.ViewModels;

namespace WS.ShowCase.ApplicationService
{
    public static class BrandAppService
    {
        public static List<BrandModel> GetBrands()
        {
            List<ProductSvc.Brand> brandsDM = null;
            using (var svc = new ProductSvc.ProductServiceClient())
            {
                brandsDM = svc.GetFilteredBrands(new ProductSvc.BrandFilter());
            }

            return brandsDM != null ? BrandAdapter.GetViewModelList(brandsDM) : null;
        }

        public static BrandModel GetBrandByBrandId(int brandId)
        {
            List<ProductSvc.Brand> brandsDM = null;
            using (var svc = new ProductSvc.ProductServiceClient())
            {
                brandsDM = svc.GetFilteredBrands(new ProductSvc.BrandFilter
                {
                    BrandId = brandId                                        
                });
            }

            return brandsDM != null ? BrandAdapter.GetViewModel(brandsDM.First()) : null;
        }

        public static void InsertBrand(BrandModel brand)
        {
            try
            {
                using (var svc = new ProductSvc.ProductServiceClient())
                {
                    // temporary info
                    brand.CreatedByUserId = 1;
                    ProductSvc.Brand brandDM = BrandAdapter.GetDomainModel(brand);
                    svc.InsertBrand(brandDM);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateBrand(BrandModel brand)
        {
            try
            {
                using (var svc = new ProductSvc.ProductServiceClient())
                {
                    ProductSvc.Brand brandDM = BrandAdapter.GetDomainModel(brand);
                    svc.UpdateBrand(brandDM);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
