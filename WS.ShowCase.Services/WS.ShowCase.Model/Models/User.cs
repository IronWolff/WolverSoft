using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Model
{
    [DataContract(Name = "User", Namespace = "http://www.wolversoft.com/ShowCase/Model/User/20131120")]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public bool IsSuperAdmin { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int CreatedByUserId { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public int? ModifiedByUserId { get; set; }

        [DataMember]
        public DateTime? ModifiedDate { get; set; }
    }
}
