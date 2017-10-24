using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstASP.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstASP.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting()
        {
            Greeting greeting = new Greeting();
            greeting.Id = 1;
            greeting.Content = "Hello World!";
            return new JsonResult(greeting);
        }
    }
}
