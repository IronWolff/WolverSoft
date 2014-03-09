using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WS.ShowCase.ViewModels
{
    public class BrandFilterViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Include Inactive")]
        public bool IncludeInactive { get; set; }
    }
}
