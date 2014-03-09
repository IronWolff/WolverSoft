using System;
using System.Runtime.Serialization;

namespace WS.Security.Model
{
    [DataContract(Name = "PermissionLevel", Namespace = "http://www.wolversoft.com/UserSecurity/Model/PermissionLevel/20130612")]
    public class PermissionLevel
    {
        [DataMember]
        public int PermissionLevelId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
