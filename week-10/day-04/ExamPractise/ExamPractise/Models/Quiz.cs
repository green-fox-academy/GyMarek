using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPractise.Models
{
    public class Quiz
    {
        [Key]
        public int QaId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
