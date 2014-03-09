using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WS.ShowCase.ViewModels
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Phone")]
        [Required]
        public string Phone { get; set; }

        [Display(Name = "Is Active")]
        [Required]
        public bool IsActive { get; set; }

        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Username")]
        [Required]
        public string Username { get; set; }

        [Display(Name = "Email")]
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage="Invalid Email Format")]
        public string Email { get; set; }

        public bool MustChangePassword { get; set; }
    }
}
