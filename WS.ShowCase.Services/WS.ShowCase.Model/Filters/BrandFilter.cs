using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Model
{
    [DataContract(Name = "BrandFilter", Namespace = "http://www.wolversoft.com/ShowCase/Model/BrandFilter/20131120")]
    public class BrandFilter : Brand
    {
        [DataMember]
        public bool? IncludeInactive { get; set; }
    }
}
