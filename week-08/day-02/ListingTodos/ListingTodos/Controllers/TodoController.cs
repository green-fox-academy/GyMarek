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

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("/list")]
        public IActionResult List()
        {
            return View(TodoRepository.GetList());
        }

        [Route("/add")]
        public IActionResult Add()
        {
            TodoRepository.AddTodo();
            return RedirectToAction("List");
        }

        [Route("/clear")]
        public IActionResult Clear()
        {
            TodoRepository.ClearDatabase();
            return RedirectToAction("List");
        }
    }
}
