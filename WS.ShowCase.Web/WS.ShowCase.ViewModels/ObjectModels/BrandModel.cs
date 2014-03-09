using System;
using System.ComponentModel.DataAnnotations;

namespace WS.ShowCase.ViewModels
{
    public class BrandModel
    {
        public int BrandId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public int CreatedByUserId { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        public int? ModifiedByUserId { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
    }
}
