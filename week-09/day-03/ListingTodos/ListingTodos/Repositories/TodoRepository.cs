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

        public List<Todos> NotDone()
        {
            var notDone = from notReady in TodoContext.Todo
                          where notReady.IsDone == false
                          select notReady;

            return notDone.ToList();
        }

        public void AddTodo(string title)
        {
            var todo = new Todos()
            {
                Title = title,
                IsDone = false,
                IsUrgent = false,
            };

            TodoContext.Todo.Add(todo);
            TodoContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteItem = from deleteOne in TodoContext.Todo
                             where deleteOne.Id == id
                             select deleteOne;

            TodoContext.Todo.Remove(deleteItem.FirstOrDefault());
            TodoContext.SaveChanges();
        }

        public Todos Updating(int id)
        {
            return TodoContext.Todo.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateTodo(Todos todo)
        {
            TodoContext.Todo.Update(todo);
            TodoContext.SaveChanges();
        }
    }
}
