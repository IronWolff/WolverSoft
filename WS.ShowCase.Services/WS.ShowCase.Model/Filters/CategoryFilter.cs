using System;
using System.Runtime.Serialization;

namespace WS.ShowCase.Model
{
    [DataContract(Name = "CategoryFilter", Namespace = "http://www.wolversoft.com/ShowCase/Model/CategoryFilter/20131120")]
    public class CategoryFilter : Category
    {
        [DataMember]
        public bool? IncludeInactive { get; set; }
    }
}
