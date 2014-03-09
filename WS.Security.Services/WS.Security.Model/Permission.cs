using System;
using System.Runtime.Serialization;

namespace WS.Security.Model
{
    [DataContract(Name = "Permission", Namespace = "http://www.wolversoft.com/UserSecurity/Model/Permission/20130612")]
    public class Permission
    {
        [DataMember]
        public int PermissionLevelId { get; set; }

        [DataMember]
        public string ApplicationCode { get; set; }

        [DataMember]
        public string ApplicationName { get; set; }

        [DataMember]
        public int ApplicationModuleId { get; set; }

        [DataMember]
        public string ApplicationModuleName { get; set; }

        [DataMember]
        public string PermissionName { get; set; }

        [DataMember]
        public string PermissionDescription { get; set; }
    }
}
