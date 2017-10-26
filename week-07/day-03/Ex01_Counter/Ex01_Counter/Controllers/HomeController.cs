using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex01_Counter.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ex01_Counter.Controllers
{
    public class HomeController : Controller
    {
        Counter counter;

        public HomeController(Counter counter) // a letrejoves pillanataban megkapja a peldanyt
        {
            this.counter = counter;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost]
        [Route("Index")]
        public IActionResult Increase()
        {
            counter.Raise();
            return RedirectToAction("Index");
        }
    }
}
