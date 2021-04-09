using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FizzBuzzWeb.Pages.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Enter an integer number")]
        [Range(1, 1000, ErrorMessage = "Number out of range 1 - 1000! Try again"),
         Required(ErrorMessage = "This field is required")]
        public int Your_Number { get; set; }

        public string result = "";

        public object FizzBuzzApp()
        {
            if (Your_Number % 3 == 0)
            {
                result += "Fizz";
            }
            if (Your_Number % 5 == 0)
            {
                result += "Buzz";
            }
            if (Your_Number % 3 != 0 && Your_Number % 5 != 0)
            {
                result += "Your number is not Fizz, Buzz or Fizzbuzz";
            }
            return null;
        }
    }
}