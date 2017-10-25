using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("simba")]
        public IActionResult Index()
        {
            var BankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000.00,
                AnimalType = AnimalType.Lion
            };
            return View(BankAccount);
        }
    }
}
