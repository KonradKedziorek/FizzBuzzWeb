using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Pages.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Enter an integer number")]
        [Range(1, 1000, ErrorMessage = "Number out of range 1 - 1000! Try again"),
         Required(ErrorMessage = "This field is required")]
        public int Your_Number { get; set; }
    }
}
