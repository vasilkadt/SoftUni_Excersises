using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person:IComparable<Person>
    {
        public string Name;
        public int Age;
        public string Town;
        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);

            if (result != 0)
            {
                return result;
            }

            result = Age.CompareTo(other.Age);

            if (result != 0)
            {
                return result;
            }

            return Town.CompareTo(other.Town);
        }
    }
}
