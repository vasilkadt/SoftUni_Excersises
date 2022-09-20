using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            double penalty = 0;
            for (int i = 0; i < tabs; i++)
            {
                string name = Console.ReadLine();
                if (name == "Facebook")
                {
                    penalty += 150;
                }
                else if (name == "Instagram")
                {
                    penalty += 100;
                }
                else if (name == "Reddit")
                {
                    penalty += 50;
                }
                else
                {
                    penalty += 0;
                }

                if (penalty >= salary)
                {
                    break;
                }
            }
            if (penalty >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else { Console.WriteLine(salary - penalty); }
        }
    }
}
