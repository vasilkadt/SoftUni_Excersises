using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int year = 1;
            double totalSumOfGrades = 0;
            int failCounter = 0;

            while (year <= 12)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());
                if (yearlyGrade < 4.00)
                {
                    failCounter++;
                    if (failCounter > 1)
                    {
                        break;
                    }
                    continue;
                }
                totalSumOfGrades += yearlyGrade;
                year++;
            }
            double averageGrade = totalSumOfGrades / 12;
            if (year <= 12)
            {
                Console.WriteLine($"{name} has been excluded at {year} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
