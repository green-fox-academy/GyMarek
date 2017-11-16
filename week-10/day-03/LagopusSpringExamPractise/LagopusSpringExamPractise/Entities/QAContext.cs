using LagopusSpringExamPractise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagopusSpringExamPractise.Entities
{
    public class QAContext : DbContext
    {
        public QAContext(DbContextOptions<QAContext> options) : base(options)
        {

        }

        public DbSet<QandA> QA { get; set; }
        public DbSet<Quiz> QAQuiz { get; set; }
    }
}
