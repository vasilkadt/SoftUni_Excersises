using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double allMoney = double.Parse(Console.ReadLine());
            int countDays = 0;
            int countSpend = 0;

            string input = "";
            double money = 0;

            while (neededMoney > allMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                countDays++;

                if (input == "spend")
                {
                    countSpend++;
                    allMoney -= money;
                    if(allMoney < 0)
                    {
                        allMoney = 0;
                    }
                    if (countSpend == 5)
                    {
                        break;
                    }
                }
                else
                {
                    allMoney += money;
                    countSpend = 0;
                }
            }
            if (countSpend == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(countDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
        }
    }
}
