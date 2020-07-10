using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Group4_Assignment2.Pages
{
    public class IndianModel : PageModel
    {
        private readonly ILogger<IndianModel> _logger;

        public IndianModel(ILogger<IndianModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
