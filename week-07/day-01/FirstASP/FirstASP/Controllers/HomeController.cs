using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstASP.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("Hello");
        }

        [Route("hello")]
        public IActionResult Hello()
        {
            return Content("Hello World!");
        }
    }
}
