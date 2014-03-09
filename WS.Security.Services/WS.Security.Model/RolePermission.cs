using System;
using System.Runtime.Serialization;

namespace WS.Security.Model
{
    [DataContract(Name = "RolePermission", Namespace = "http://www.wolversoft.com/UserSecurity/Model/RolePermission/20130612")]
    public class RolePermission
    {
        [DataMember]
        public int RoleId { get; set; }

        [DataMember]
        public int ApplicationModuleId { get; set; }

        [DataMember]
        public int PermissionLevelId { get; set; }
    }
}
