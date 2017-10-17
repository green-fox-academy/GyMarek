﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Greenfox
{
    class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.level = level;
        }

        public Mentor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("My Goal is: Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor.", name, age, gender, level);
        }
    }
}
