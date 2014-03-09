using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WS.ShowCase.Model;
using WS.ShowCase.Model.Models;

namespace WS.ShowCase.Services.Task
{
    [ServiceContract(Namespace = "http://www.wolversoft.com/ShowCase/IProductService/230132111", SessionMode = SessionMode.Allowed)]
    public interface IProductService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        int InsertBrand(Brand brand);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void UpdateBrand(Brand brand);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        List<Brand> GetFilteredBrands(BrandFilter filter);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        int InsertCategory(Category category);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void UpdateCategory(Category category);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        List<Category> GetFilteredCategories(CategoryFilter filter);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        int InsertProduct(Product product);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void UpdateProduct(Product product);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        List<Product> GetFilteredProducts(ProductFilter filter);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        int InsertProvider(Provider provider);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void UpdateProvider(Provider provider);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        List<Provider> GetFilteredProviders(ProviderFilter filter);
    }
}
