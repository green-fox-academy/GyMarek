using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Greenfox
{
    class PallidaClass
    {
        private string className;
        private List<Student> students= new List<Student>();
        private List<Mentor> mentors = new List<Mentor>();

        public PallidaClass(string className, List<Student> students, List<Mentor> mentors)
        {
            this.className = className;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(new Student());           
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(new Mentor());
        }

        public void Info()
        {
            Console.WriteLine("Pallida {0} class has {1} students and {2} mentors.", className, students.Count, mentors.Count);
        }
    }
}
