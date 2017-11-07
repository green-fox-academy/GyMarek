using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet]
        [Route("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }

        [HttpGet]
        [Route("appenda/{appendable}")]
        [Route("appenda")]
        public IActionResult Appenda(string appendable)
        {
            if (String.IsNullOrEmpty(appendable))
            {
                return NotFound();
            }
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpPost]
        [Route("dountil/{what}")]
        [Route("dountil")]
        public IActionResult DoUntil(string what, [FromBody] DoU dou)
        {          
            int resultNumber = 0;

            if (dou == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            if (string.IsNullOrEmpty(what))
            {
                return NotFound();
            }
            if (what == "sum")
            {
                for (int i = 0; i <= dou.Until; i++)
                {
                    resultNumber += i;
                }
            }
            if (what == "factor")
            {
                resultNumber = 1;
                for (int i = 1; i <= dou.Until; i++)
                {
                    resultNumber *= i;
                }
            }

            return Json(new { result = $"{resultNumber}" });
        }

        public class DoU
        {
            public int? Until { get; set; }
        }
    }
}
