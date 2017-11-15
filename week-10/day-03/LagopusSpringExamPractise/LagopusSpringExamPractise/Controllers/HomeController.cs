using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LagopusSpringExamPractise.Models;
using LagopusSpringExamPractise.Repositories;

namespace LagopusSpringExamPractise.Controllers
{
    public class HomeController : Controller
    {
        QandA qAndA;
        QARepository qARepository;

        public HomeController(QandA qAndA, QARepository qARepository)
        {
            this.qAndA = qAndA;
            this.qARepository = qARepository;
        }

        [HttpGet]
        [Route("/questions")]
        public IActionResult Index()
        {
            return View(qARepository.GetRandomList());
        }
    }
}
