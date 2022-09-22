﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string command = Console.ReadLine();
            while (command != "exam finished")
            {
                string[] tokens = command.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string user = tokens[0];
                string language = tokens[1];
                if (language == "banned")
                {
                    students.Remove(user);
                    command = Console.ReadLine();
                    continue;
                }
                int points = int.Parse(tokens[2]);

                if (!students.ContainsKey(user))
                {
                    students.Add(user, 0);
                }

                if (students[user] < points)
                {
                    students[user] = points;
                }

                if (!submissions.ContainsKey(language))
                {
                    submissions.Add(language, 0);
                }
                submissions[language]++;

                command = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            students = students.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            submissions = submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Submissions:");
            foreach (var submission in submissions)
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
