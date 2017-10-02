using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Counter
{
    public class CounterApp
    {
        //Create Counter class
        //which has an integer property
        //when creating it should have a default value 0 or we can specify it when creating
        //we can Add(number) to this counter another whole number
        //or we can Add() without parameters just increasing the counter's value by one
        //and we can Get() the current value as string
        //also we can Reset() the value to the initial value

        private int number = 0;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public void Add(int addnumber)
        {
            number += addnumber;
        }

        public void Add()
        {
            number += 1;
        }

        public string GetCounter()
        {
            return number.ToString();
        }

        public void ResetCouter()
        {
            number = 0;
        }
    }
}
