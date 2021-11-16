using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVCData.ViewModels
{
    public class CreatePersonViewModel
    {
        [Display(Name="Name")]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }
        [Display(Name = "Phone-number")]
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string PhoneNumber { get; set; }
        [Display(Name = "City")]
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string City { get; set; }

    }
}
