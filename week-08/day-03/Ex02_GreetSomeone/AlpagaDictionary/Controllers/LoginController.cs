﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace AlpagaDictionary.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult IndexLogin()
        {
            return View();
        }
    }
}
