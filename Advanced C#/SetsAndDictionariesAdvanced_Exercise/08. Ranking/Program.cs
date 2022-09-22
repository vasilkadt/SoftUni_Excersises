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
            SortedDictionary<string, Dictionary<string, int>> competitors = new SortedDictionary<string, Dictionary<string, int>>();

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
                    if (!competitors[competitorName].ContainsKey(contestName))
                    {
                        competitors[competitorName].Add(contestName, 0);
                    }
                    if (competitors[competitorName][contestName] < points)
                    {
                        competitors[competitorName][contestName] = points;
                    }
                }

                input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }

            string bestCompetitor = competitors.OrderByDescending(x => x.Value.Values.Sum()).First().Key;
            int bestCandidatePoints = competitors[bestCompetitor].Values.Sum();
            Console.WriteLine($"Best candidate is {bestCompetitor} with total {bestCandidatePoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var competitor in competitors)
            {
                Console.WriteLine($"{competitor.Key}");
                var orderedPoints = competitor.Value.OrderByDescending(x => x.Value);
                foreach (var competition in orderedPoints)
                {
                    Console.WriteLine($"#  {competition.Key} -> {competition.Value}");
                }
            }
        }
    }
}