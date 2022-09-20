using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumFirstDigitIntervalStart = int.Parse(Console.ReadLine());
            int firstNumSecondDigitIntervalEnd = int.Parse(Console.ReadLine());
            int secondNumFirstDigitIntervalStart = int.Parse(Console.ReadLine());
            int secondNumSecondDigitIntervalEnd = int.Parse(Console.ReadLine());

            int firstNumFirstDigitIntervalEnd = 8;
            int firstNumSecondDigitIntervalStart = 9;
            int secondNumFirstDigitIntervalEnd = 8;
            int secondNumSecondDigitIntervalStart = 9;
            int counter = 0;

            for (int i = firstNumFirstDigitIntervalStart; i <= firstNumFirstDigitIntervalEnd; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                for (int j = firstNumSecondDigitIntervalStart; j >= firstNumSecondDigitIntervalEnd; j--)
                {
                    if (j % 2 == 0)
                    {
                        continue;
                    }

                    for (int k = secondNumFirstDigitIntervalStart; k <= secondNumFirstDigitIntervalEnd; k++)
                    {
                        if (k % 2 == 1)
                        {
                            continue;
                        }

                        for (int p = secondNumSecondDigitIntervalStart; p >= secondNumSecondDigitIntervalEnd; p--)
                        {
                            if (p % 2 == 0)
                            {
                                continue;
                            }

                            if (i == k && j == p)
                            {
                                Console.WriteLine("Cannot change the same player.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"{i}{j} - {k}{p}");
                            }

                            counter++;
                            if (counter == 6)
                            {
                                break;
                            }
                        }

                        if (counter == 6)
                        {
                            break;
                        }
                    }

                    if (counter == 6)
                    {
                        break;
                    }
                }

                if (counter == 6)
                {
                    break;
                }
            }
        }
    }
}