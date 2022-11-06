using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command
                    .Split(";");
                string cmdType = cmdArgs[0];
                string teamName = cmdArgs[1];

                try
                {
                    if (cmdType == "Team")
                    {
                        Team newTeam = new Team(teamName);
                        teams.Add(newTeam);
                    }
                    else if (cmdType == "Add")
                    {
                        Team joiningTeam = teams.FirstOrDefault(t => t.Name == teamName);
                        if (joiningTeam == null)
                        {
                            throw new InvalidOperationException(string.Format(ExeptionMessages.InexistingTeamMessage, teamName));
                        }

                        string playerName = cmdArgs[2];
                        int endurance = int.Parse(cmdArgs[3]);
                        int sprint = int.Parse(cmdArgs[4]);
                        int dribble = int.Parse(cmdArgs[5]);
                        int passing = int.Parse(cmdArgs[6]);
                        int shooting = int.Parse(cmdArgs[7]);

                        Player joiningPlayer = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        joiningTeam.AddPlayer(joiningPlayer);
                    }
                    else if (cmdType == "Remove")
                    {
                        string playerName = cmdArgs[2];
                        Team removingTeam = teams.FirstOrDefault(t => t.Name == teamName);
                        if (removingTeam == null)
                        {
                            throw new InvalidOperationException(string.Format(ExeptionMessages.InexistingTeamMessage, teamName));
                        }

                        removingTeam.RemovePlayer(playerName);
                    }
                    else if (cmdType == "Rating")
                    {
                        Team teamToRate = teams.FirstOrDefault(t => t.Name == teamName);
                        if (teamToRate == null)
                        {
                            throw new InvalidOperationException(string.Format(ExeptionMessages.InexistingTeamMessage, teamName));
                        }
                        Console.WriteLine(teamToRate);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch(InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
        }
    }
}
