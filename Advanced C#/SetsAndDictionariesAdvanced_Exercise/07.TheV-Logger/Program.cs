using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vlog = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] data = input.Split();

                string vlogger = data[0];
                string command = data[1];

                if (command == "joined")
                {
                    if (vlog.ContainsKey(vlogger) == false)
                    {
                        vlog.Add(vlogger, new Dictionary<string, HashSet<string>>());
                        vlog[vlogger].Add("followers", new HashSet<string>());
                        vlog[vlogger].Add("following", new HashSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    string member = data[2];

                    if (vlogger != member && vlog.ContainsKey(vlogger) && vlog.ContainsKey(member))
                    {
                        vlog[vlogger]["following"].Add(member);
                        vlog[member]["followers"].Add(vlogger);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vlog.Count} vloggers in its logs.");

            int number = 1;

            vlog = vlog.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count).ToDictionary(x => x.Key, x => x.Value);
            foreach (var vlogger in vlog)
            {
                Console.WriteLine($"{number}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (number == 1)
                {
                    foreach (string follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                number++;
            }
        }
    }
}