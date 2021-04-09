using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzWeb.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FizzBuzzWeb.Pages
{
    public class FizzBuzzModel : PageModel
    {
        public FizzBuzz FizzBuzz { get; set; }
        public void OnGet()
        {
            var SessionFizzBuzz = HttpContext.Session.GetString("SessionFizzBuzz");
            if (SessionFizzBuzz != null)
            {
                FizzBuzz = JsonConvert.DeserializeObject<FizzBuzz>(SessionFizzBuzz);
            }
        }
    }
}