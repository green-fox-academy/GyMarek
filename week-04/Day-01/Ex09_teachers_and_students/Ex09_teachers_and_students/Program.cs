using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_teachers_and_students
{
    class Program
    {
        static void Main(string[] args)
        {
        //Create Student and Teacher classes
        //  Student
        //      learn()
        //      question(teacher)->calls the teachers answer method
        //  Teacher
        //      teach(student)->calls the students learn method
        //      answer()

            Teacher teacher = new Teacher();
            Student student = new Student();

            Teacher.Teach();
            Student.Question();
            Console.ReadLine();
        }
    }
}
