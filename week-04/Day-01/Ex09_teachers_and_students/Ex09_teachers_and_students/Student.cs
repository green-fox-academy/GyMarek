using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_teachers_and_students
{
    class Student
    {
        public static void Learn()
        {
            Console.WriteLine("Student learning");
        }
        public static void Question()
        {
            Console.WriteLine("What is the answer to the ultimate question of life, the universe and everything?");
            Teacher.Answer();
        }
    }
}
