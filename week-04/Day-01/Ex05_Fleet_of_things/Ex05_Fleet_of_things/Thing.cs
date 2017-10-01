using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Fleet_of_things
{
    public class Thing
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }

        public string GetName()             // Method
        {
            return this.Name;
        }

        public bool IsCompleted()           // Method
        {
            return this.Completed;
        }
    }
}
