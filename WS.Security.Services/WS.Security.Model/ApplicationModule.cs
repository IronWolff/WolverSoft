using System;
using System.Runtime.Serialization;

namespace WS.Security.Model
{
    [DataContract(Name = "ApplicationModule", Namespace = "http://www.wolversoft.com/UserSecurity/Model/ApplicationModule/20130612")]
    public class ApplicationModule
    {
        [DataMember]
        public int ApplicationModuleId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int ApplicationId { get; set; }
    }
}
