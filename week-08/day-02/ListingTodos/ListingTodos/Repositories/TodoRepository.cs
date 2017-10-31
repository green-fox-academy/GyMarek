using ListingTodos.Entities;
using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public class TodoRepository
    {
        private TodoContext TodoContext;

        public List<Todos> GetList()
        {
            return TodoContext.Todo.ToList();
        }

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public void AddTodo()
        {
            var todo = new Todos()
            {
                Title = "do lunch",
                IsDone = true,
                IsUrgent = true
            };

            TodoContext.Todo.Add(todo);
            TodoContext.SaveChanges();
        }

        public Todos GetLastTodo()
        {
            return TodoContext.Todo.Last();
        }

        public void ClearDatabase()
        {
            TodoContext.Todo.RemoveRange(TodoContext.Todo.Where(t => t.Id>0));
            
            TodoContext.SaveChanges();
        }
    }
}
