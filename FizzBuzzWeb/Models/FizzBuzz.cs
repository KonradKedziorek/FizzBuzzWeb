using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzzWeb.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace FizzBuzzWeb.Pages.Models
{
    public class FizzBuzz
    {
        public int ID { get; set; }

        [Display(Name = "Enter an integer number")]
        [Range(1, 1000, ErrorMessage = "Number out of range 1 - 1000! Try again"),
         Required(ErrorMessage = "This field is required")]
        public int Your_Number { get; set; }

        public DateTime time { get; set; } = DateTime.Now;

        public string result { get; set; } = "";
        public int IdForeignKey { get; set; }

        [ForeignKey("IdForeignKey")]
        public AspNetUsers Id { get; set; }

        public string FizzBuzzApp()
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
            return result;
        }
    }
}