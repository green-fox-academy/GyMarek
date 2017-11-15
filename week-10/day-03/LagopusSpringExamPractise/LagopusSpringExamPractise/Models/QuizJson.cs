using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagopusSpringExamPractise.Models
{
    public class QuizJson
    {
        public Questions IdAndQuestion { get; set; }
        public Answers IdAndAnswers { get; set; }        
    }

    public class Questions
    {
        public int QandAId { get; set; }
        public string Question { get; set; }
    }

    public class Answers
    {
        public int QandAId { get; set; }
        public string Answer { get; set; }
    }
}
