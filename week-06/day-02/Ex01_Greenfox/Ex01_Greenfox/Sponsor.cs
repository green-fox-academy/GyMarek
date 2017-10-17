using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Greenfox
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string name, int age, string gender, string company)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.company = company;
        }

        public Sponsor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            company = "Google";
            hiredStudents = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My Goal is: Hire brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represent {3} and hired {4} students so far.", name, age, gender, company, hiredStudents);
        }

        public void Hire()
        {
            hiredStudents +=1;
        }
    }
}
