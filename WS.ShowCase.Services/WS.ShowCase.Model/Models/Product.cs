using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Model
{
    [DataContract(Name = "Product", Namespace = "http://www.wolversoft.com/ShowCase/Model/Product/20131120")]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int ProviderId { get; set; }

        public int BrandId { get; set; }

        public int CategoryId { get; set; }

        [DataMember]
        public int CreatedByUserId { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public int? ModifiedByUserId { get; set; }

        [DataMember]
        public DateTime? ModifiedDate { get; set; }

        [DataMember]
        public bool IsActive { get; set; }
    }
}
