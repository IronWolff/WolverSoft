using System.Collections.Generic;
using System.Linq;
using WS.ShowCase.Model;

namespace WS.ShowCase.Repository
{
    public static class ProviderAdapter
    {
        public static Provider GetModelObject(DataAccess.Provider provider)
        {
            return new Provider
            {
                Address1 = provider.Address1,
                Address2 = provider.Address2,
                CreatedByUserId = provider.CreatedByUserId,
                CreatedDate = provider.CreatedDate,
                Description = provider.Description,
                Email = provider.Email,
                IsActive = provider.IsActive,
                ModifiedByUserId = provider.ModifiedByUserId,
                ModifiedDate = provider.ModifiedDate,
                Name = provider.Name,
                OwnerFirstName = provider.OwnerFirstName,
                OwnerLastName = provider.OwnerLastName,
                Phone = provider.Phone,
                ProviderId = provider.ProviderId
            };
        }

        public static DataAccess.Provider GetDAModel(Provider provider)
        {
            return new DataAccess.Provider
            {
                Address1 = provider.Address1,
                Address2 = provider.Address2,
                CreatedByUserId = provider.CreatedByUserId,
                CreatedDate = provider.CreatedDate,
                Description = provider.Description,
                Email = provider.Email,
                IsActive = provider.IsActive,
                ModifiedByUserId = provider.ModifiedByUserId,
                ModifiedDate = provider.ModifiedDate,
                Name = provider.Name,
                OwnerFirstName = provider.OwnerFirstName,
                OwnerLastName = provider.OwnerLastName,
                Phone = provider.Phone,
                ProviderId = provider.ProviderId
            };
        }

        public static List<Provider> GetModelObjectList(List<DataAccess.Provider> providers)
        {
            return providers.Select(provider => GetModelObject(provider)).ToList();
        }

        public static List<DataAccess.Provider> GetDAModelList(List<Provider> providers)
        {
            return providers.Select(provider => GetDAModel(provider)).ToList();
        }
    }
}
