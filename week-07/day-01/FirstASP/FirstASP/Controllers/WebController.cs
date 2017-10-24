using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstASP.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstASP.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        static int loadedPage = 0;

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting()
            {
                Id = ++ loadedPage,
                Content = $"{name}"
            };

            return View(greeting);
        }
    }
}
