﻿using System;
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
            Person Jane = new Person();

            Jane.Introduce();
            Jane.GetGoal();

            Student Jane2 = new Student();
            Jane2.Introduce();

            Console.ReadLine();
        }
    }
}
