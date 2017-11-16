using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamPractise.Models;
using ExamPractise.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamPractise.Controllers
{
    public class HomeController : Controller
    {
        Quiz quiz;
        RandomQuiz randomQuiz;
        QuizRepository quizRepository;

        public HomeController(Quiz quiz, RandomQuiz randomQuiz, QuizRepository quizRepository)
        {
            this.quiz = quiz;
            this.randomQuiz = randomQuiz;
            this.quizRepository = quizRepository;
        }
        
        [HttpGet]
        [Route("question")]
        public IActionResult Question()
        {
            return Json(quizRepository.GetRandomQuestion());
        }

        [HttpPost]
        [Route("answer")]
        public IActionResult Answer()
        {
            return Json(quizRepository.GetRandomAnswer());
        }
    }
}
