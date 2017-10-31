using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models
{
    public class Todocs
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent = false;
        public bool IsDone = false;
    }
}
