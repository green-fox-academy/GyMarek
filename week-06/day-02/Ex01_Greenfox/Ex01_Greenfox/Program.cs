using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Greenfox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Person mark = new Person("Mark", 46, "male");
            people.Add(mark);
            Person jane = new Person();
            people.Add(jane);
            
            Student john = new Student("John Doe", 20, "male", "BME");
            people.Add(john);
            Student johnTheClone = (Student)john.Clone();
            people.Add(johnTheClone);

            Student student = new Student();
            people.Add(student);
            Mentor gandhi = new Mentor("Gandhi", 148, "male", "senior");
            people.Add(gandhi);
            Mentor mentor = new Mentor();
            people.Add(mentor);
            Sponsor sponsor = new Sponsor();
            people.Add(sponsor);
            Sponsor elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            people.Add(elon);

            student.Skipdays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }
            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (Person person in people)
            {
                person.Introduce();
                person.GetGoal();
            }

            PallidaClass alpaga = new PallidaClass("Alpaga", null, null);
            alpaga.AddStudent(student);
            alpaga.AddStudent(john);
            alpaga.AddMentor(mentor);
            alpaga.AddMentor(gandhi);
            alpaga.Info();

            Console.ReadLine();
        }
    }
}