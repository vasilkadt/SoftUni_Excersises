using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> course = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];

                if (!course.ContainsKey(courseName))
                {
                    course[courseName] = new List<string>();
                }
                course[courseName].Add(studentName);

            }

            foreach (var item in course)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
