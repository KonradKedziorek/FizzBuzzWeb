using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzzWeb.Pages.Models;
using FizzBuzzWeb.Data;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private FizzBuzzContext fizzBuzzContext;
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

        //public string result = "";

        public IndexModel(ILogger<IndexModel> logger, FizzBuzzContext context)
        {
            fizzBuzzContext = context;
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("SessionFizzBuzz", JsonConvert.SerializeObject(FizzBuzz));
                FizzBuzz.result = FizzBuzz.FizzBuzzApp();
                fizzBuzzContext.Add(FizzBuzz);
                fizzBuzzContext.SaveChanges();
                FizzBuzz.result = "";
                return Page();
            }
            return Page();
        }
    }
}
