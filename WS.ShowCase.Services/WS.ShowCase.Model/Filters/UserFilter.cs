using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Model
{
    [DataContract(Name = "UserFilter", Namespace = "http://www.wolversoft.com/ShowCase/Model/UserFilter/20131121")]
    public class UserFilter : User
    {
        [DataMember]
        public bool? IncludeInactive { get; set; }
    }
}
