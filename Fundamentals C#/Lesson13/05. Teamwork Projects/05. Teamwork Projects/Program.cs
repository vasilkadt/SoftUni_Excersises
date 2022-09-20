using System;
using System.Collections.Generic;
using System.Linq;
//there are some mistakes in the program, the solution is not right
namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int n = int.Parse(Console.ReadLine());
            registerTeams(teams, n);

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinArg = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string memberName = joinArg[0];
                string teamName = joinArg[1];

                Team searchedTeam = teams.FirstOrDefault(t => t.Name == teamName);
                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (isAlreadyMemborOfTeam(teams, memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!&");
                    continue;
                }

                if (teams.Any(t => t.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!&");
                    continue;
                }

                searchedTeam.addMember(memberName);
            }
            List<Team> teamsWithMembers = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();
            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();

            foreach (Team validTeam in teamsWithMembers)
            {
                Console.WriteLine($"{validTeam.Name}");
                Console.WriteLine($"- {validTeam.Creator}");

                foreach (string currMember in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {currMember}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team invalidTeams in teamsToDisband)
            {
                Console.WriteLine(invalidTeams.Name);
            }
        }

        static bool isAlreadyMemborOfTeam(List<Team> teams, string memberName)
        {
            foreach (Team team in teams)
            {
                if (team.Members.Contains(memberName))
                {
                    return true;
                }
            }
            return false;
        }

        static void registerTeams(List<Team> teams, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] teamArg = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creatorName = teamArg[0];
                string teamName = teamArg[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }
        }
    }

    class Team
    {
        public Team(string teamName, string creatorName)
        {
            this.Name = teamName;
            this.Creator = creatorName;
            this.Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public void addMember(string member)
        {
            this.Members.Add(member);
        }
    }
}
