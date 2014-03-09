using System;
using System.Runtime.Serialization;

namespace WS.Security.Model
{
    [DataContract(Name = "Application", Namespace = "http://www.wolversoft.com/UserSecurity/Model/Application/20130612")]
    public class Application
    {
        [DataMember]
        public string ApplicationName { get; set; }

        [DataMember]
        public string ApplicationCode { get; set; }

        [DataMember]
        public int ApplicationId { get; set; }
    }
}
