using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FizzBuzzWeb.Data;
using FizzBuzzWeb.Pages.Models;

namespace FizzBuzzWeb.Pages.Results
{
    public class IndexModel : PageModel
    {
        private readonly FizzBuzzWeb.Data.FizzBuzzContext _context;

        public IndexModel(FizzBuzzWeb.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        public IList<FizzBuzz> FizzBuzz { get;set; }

        public void OnGet()
        {
            //FizzBuzz = await _context.FizzBuzz.ToListAsync();
            FizzBuzz = _context.FizzBuzz.OrderByDescending(d => d.time).Take(10).ToList();
        }

    }
}
