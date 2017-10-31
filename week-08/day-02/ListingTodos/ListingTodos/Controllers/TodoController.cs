using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListingTodos.Repositories;

namespace ListingTodos.Controllers
{
    [Route("")]
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        [Route("/list")]
        public IActionResult List()
        {
            return View();
        }
    }
}
