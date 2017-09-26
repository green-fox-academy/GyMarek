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
        private string v1;
        private int v2;
        private int v3;

        public PallidaClass(string className, List<Student> students, List<Mentor> mentors)
        {
            this.className = className;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public PallidaClass(string v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
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
