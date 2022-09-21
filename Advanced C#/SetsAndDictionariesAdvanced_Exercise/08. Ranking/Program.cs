using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> competitors = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "end of contests")
            {
                if (!contests.ContainsKey(input[0]))
                {
                    contests.Add(input[0], string.Empty);
                }
                contests[input[0]] = input[1];
                input = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "end of submissions")
            {
                string contestName = input[0];
                string password = input[1];
                string competitorName = input[2];
                int points = int.Parse(input[3]);

                if (contests.ContainsKey(contestName) && contests[contestName] == password)
                {
                    if (!competitors.ContainsKey(competitorName))
                    {
                        competitors.Add(competitorName, new Dictionary<string, int>());
                    }
                    if(!competitors[competitorName].ContainsKey(contestName))
                    {
                        competitors[competitorName].Add(contestName, 0);
                    }
                    competitors[competitorName][contestName] = points;
                }

                input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            competitors = competitors.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            int sum = 0;
            int max = 0;
            string bestName = string.Empty;

            Console.WriteLine($"Best candidate is {bestName} with total {max} points.");

            foreach (var competitor in competitors)
            {
                Console.WriteLine("Ranking:");
                Console.WriteLine($"{competitor.Key}");
                foreach (var competition in competitor.Value)
                {
                    Console.WriteLine($"# {competition.Key} -> {competition.Value}");
                    sum += competition.Value;
                }

                if (sum > max)
                {
                    max = sum;
                    sum = 0;
                    bestName = competitor.Key;
                }
            }
        }
    }
}
