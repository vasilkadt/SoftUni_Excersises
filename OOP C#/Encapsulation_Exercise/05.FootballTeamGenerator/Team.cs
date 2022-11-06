using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;
        private Team()
        {
            players = new List<Player>();
        }
        public Team(string name)
            : this()
        {
            Name = name;
        }
        public string Name
        {
            get => name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExeptionMessages.NameCannotBeNullOrWhiteSpace);
                }
                name = value;
            }
        }
        public int Rating
            => players.Count > 0 ?
            (int)Math.Round(players.Average(p => p.OveralRating), 0) : 0;
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            Player playerToRemove = players.FirstOrDefault(p => p.Name == playerName);
            if (playerToRemove == null)
            {
                throw new InvalidOperationException(string.Format(ExeptionMessages.MissingPlayerMessage, playerName, Name));
            }
            players.Remove(playerToRemove);
        }
        public override string ToString()
        {
            return $"{Name} - {Rating}";
        }
    }
}
