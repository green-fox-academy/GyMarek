using ExamPractise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPractise.Entities
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {

        }

        public DbSet<Quiz> QuizTable { get; set; }
        public DbSet<RandomQuiz> RandomQuizTable { get; set; }
    }
}
