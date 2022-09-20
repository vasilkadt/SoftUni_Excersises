using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public double grade { get; set; }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName}: {this.grade:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currStudentFirstName = studentArgs[0];
                string currStudentLastName = studentArgs[1];
                double currStudetGrade = double.Parse(studentArgs[2]);

                Student currStudent = new Student(currStudentFirstName, currStudentLastName, currStudetGrade);
                students.Add(currStudent);
            }
            //List<Student> orderedStudents = students.OrderByDescending(s => s.grade).ToList();
            students = students.OrderByDescending(s => s.grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
