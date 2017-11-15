using LagopusSpringExamPractise.Entities;
using LagopusSpringExamPractise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagopusSpringExamPractise.Repositories
{
    public class QARepository
    {
        private QAContext QAContext;

        public QARepository(QAContext qAContext)
        {
            QAContext = qAContext;
        }

        public List<QandA> GetList()
        {
            return QAContext.QA.ToList();
        }
    }
}
