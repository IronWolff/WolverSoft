using System;
using System.Runtime.Serialization;

namespace WS.Security.Model
{
    [DataContract(Name = "Role", Namespace = "http://www.wolversoft.com/UserSecurity/Model/Role/20130612")]
    public class Role
    {
        [DataMember]
        public int RoleId { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int ClientId { get; set; }
    }
}
