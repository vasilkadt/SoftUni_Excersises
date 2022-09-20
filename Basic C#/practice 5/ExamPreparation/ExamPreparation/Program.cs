using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedTimes = int.Parse(Console.ReadLine());
            double gradeSum = 0;
            int gradeCounter = 0;
            string lasteExercise = "";
            int failedCount = 0;

            string input = Console.ReadLine();
            int grade = 0;
            while (input != "Enough")
            {
                lasteExercise = input;
                grade = int.Parse(Console.ReadLine());
                gradeSum += grade;
                gradeCounter++;

                if (grade <= 4.00)
                {
                    failedCount++;
                    if (failedTimes == failedCount)
                    { 
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {(gradeSum/gradeCounter):f2}");
                Console.WriteLine($"Number of problems: {gradeCounter}");
                Console.WriteLine($"Last problem: {lasteExercise}");
            }
            else
            {
                Console.WriteLine($"You need a break, {failedCount} poor grades.");
            }
        }
    }
}
