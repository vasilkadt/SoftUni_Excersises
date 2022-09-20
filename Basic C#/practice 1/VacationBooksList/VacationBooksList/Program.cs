using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());
            int allTime = numberOfPages / pagesPerHour;
            int timeForDay = allTime / numberOfDays;
            Console.WriteLine(timeForDay);
        }
    }
}
