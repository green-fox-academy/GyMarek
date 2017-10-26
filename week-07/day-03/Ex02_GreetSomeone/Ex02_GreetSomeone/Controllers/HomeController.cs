using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex02_GreetSomeone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ex02_GreetSomeone.Controllers
{
    public class HomeController : Controller
    {
        Greet greet;

        public HomeController(Greet greet)
        {
            this.greet = greet;
        }

        [HttpGet]
        [Route("")]
        public IActionResult IndexWithForm()
        {
            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Index(string name)
        {
            greet.Name = name;
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("submit")]
        public IActionResult Index()
        {           
            return View(greet);
        }
    }
}