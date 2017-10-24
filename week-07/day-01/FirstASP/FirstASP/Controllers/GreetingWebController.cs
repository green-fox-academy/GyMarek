﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstASP.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstASP.Controllers
{
    [Route("web")]
    public class GreetingWebController : Controller
    {
        [Route("greetingall")]
        public IActionResult GreetingAll()
        {
            return View(Greeting.hellos);
        }
    }
}

