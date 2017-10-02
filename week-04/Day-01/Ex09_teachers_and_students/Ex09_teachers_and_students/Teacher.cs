using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_teachers_and_students
{
    class Teacher
    {
        public static void Teach()
        {
            Student.Learn();
        }
        public static void Answer()
        {
            Console.WriteLine("42");
        }
    }
}
