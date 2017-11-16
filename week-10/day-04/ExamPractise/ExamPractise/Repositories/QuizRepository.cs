using ExamPractise.Entities;
using ExamPractise.Models;
using ExamPractise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPractise.Repositories
{
    public class QuizRepository
    {
        private QuizContext QuizContext;

        public QuizRepository(QuizContext quizContext)
        {
            QuizContext = quizContext;
        }

        public List<Quiz> GetList()
        {
            return QuizContext.QuizTable.ToList();
        }

        public List<Quiz> GetRandomList()
        {
            var randomRecord = (from qaId in QuizContext.QuizTable.AsEnumerable()
                                orderby Guid.NewGuid()
                                select qaId).Take(5);

            return randomRecord.ToList();
        }

        public List<RandomQuestions> GetRandomQuestion()
        {
            var quizList = GetRandomList();
            var selectedQuestions = (from quiz in quizList
                                     orderby quiz.QaId
                                     select new { quiz.QaId, quiz.Question }).ToList();

            List<RandomQuestions> newrandom = new List<RandomQuestions>();

            foreach (var q in selectedQuestions)
            {
                newrandom.Add(new RandomQuestions { QaId = q.QaId, Question = q.Question });
            }

            return newrandom;
        }

        public List<RandomAnswer> GetRandomAnswer()
        {
            var quizList = GetRandomList();
            var selectedQuestions = (from quiz in quizList
                                     orderby quiz.QaId
                                     select new { quiz.QaId, quiz.Answer }).ToList();

            List<RandomAnswer> newrandom = new List<RandomAnswer>();

            foreach (var q in selectedQuestions)
            {
                newrandom.Add(new RandomAnswer { QaId = q.QaId, Answer = q.Answer });
            }

            return newrandom;
        }

    }
}
