using System;
using System.Runtime.Serialization;

namespace WS.Security.Model
{
    [DataContract(Name = "User", Namespace = "http://www.wolversoft.com/Security/Model/User/20130612")]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public bool MustChangePassword { get; set; }
    }
}
