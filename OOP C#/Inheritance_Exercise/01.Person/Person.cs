using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Person
{
    public class Person
    {
        private int age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual string Name { get; set; }
        public virtual int Age 
        {
            get { return age; } 
            set 
            { 
                if (value > 0)
                {
                    age = value;
                }

            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {Name}, Age: {Age}"));
            return stringBuilder.ToString();
        }
    }
}
