using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] information = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = information[0];
                string lastName = information[1];
                int age = int.Parse(information[2]);
                string homeTown = information[3];

                Student newStudent = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };
                students.Add(newStudent);
            }
            string city = Console.ReadLine();
            List<Student> filteredStudents = students.FindAll(student => student.HomeTown == city);

            foreach(Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
