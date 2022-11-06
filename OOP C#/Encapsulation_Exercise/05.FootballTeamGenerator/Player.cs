using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private string name;
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Stats = new Stats(endurance, sprint, dribble, passing, shooting);
        }
        public string Name 
        {
            get => name;
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExeptionMessages.NameCannotBeNullOrWhiteSpace);
                }
                name = value;
            }
        }
        public Stats Stats { get; private set; }
        public double OveralRating
            => (Stats.Endurance + Stats.Sprint + Stats.Dribble + Stats.Passing + Stats.Shooting) / 5.0;
    }
}
