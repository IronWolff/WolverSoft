using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Model
{
    [DataContract(Name = "Provider", Namespace = "http://www.wolversoft.com/ShowCase/Model/Provider/20131120")]
    public class Provider
    {
        [DataMember]
        public int ProviderId { get; set; }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Address1 { get; set; }

        [DataMember]
        public string Address2 { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string OwnerFirstName { get; set; }

        [DataMember]
        public string OwnerLastName { get; set; }

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

        [DataMember]
        public string Zip { get; set; }
    }
}
