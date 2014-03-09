using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Model
{
    [DataContract(Name = "ProductFilter", Namespace = "http://www.wolversoft.com/ShowCase/Model/ProductFilter/20131120")]
    public class ProductFilter : Product
    {
        [DataMember]
        public bool? IncludeInactive { get; set; }
    }
}
