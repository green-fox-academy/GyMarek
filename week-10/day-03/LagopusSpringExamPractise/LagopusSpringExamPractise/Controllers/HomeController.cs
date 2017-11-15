using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LagopusSpringExamPractise.Models;
using LagopusSpringExamPractise.Repositories;
using Newtonsoft.Json;

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
        [Route("question")]
        public IActionResult Question()
        {
            var quizList = qARepository.GetRandomList();
            var selectedQuestions = (from quiz in quizList
                                     orderby quiz.QandAId
                                     select new { quiz.QandAId, quiz.Question }).ToList();
            return Json(selectedQuestions);
        }

        //[HttpPost]
        //[Route("answer")]
        //public IActionResult Answer(string what, QandA qandA)
        //{
        //    //var quizList = qARepository.GetRandomList();
        //    //var selectedQuestions = (from quiz in quizList
        //    //                         orderby quiz.QandAId
        //    //                         select new { quiz.QandAId, quiz.Question }).ToList();
        //    //return Json(selectedQuestions);
        //}
    }
}
