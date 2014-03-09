using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Model
{
    [DataContract(Name = "ProviderFilter", Namespace = "http://www.wolversoft.com/ShowCase/Model/ProviderFilter/20131120")]
    public class ProviderFilter : Provider
    {
        [DataMember]
        public bool? IncludeInactive { get; set; }
    }
}
