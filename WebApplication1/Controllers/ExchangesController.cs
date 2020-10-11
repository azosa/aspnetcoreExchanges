using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ExchangesController : Controller
    {
        [HttpGet]
        public IActionResult Display()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Display(CompanyModel company)
        {
            var viewModel = new CompanyAddedViewModel
            {
                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                IsHidden = !company.IsVisible
            };
            return View("CompanyAdded", viewModel);
        }
    }
}
