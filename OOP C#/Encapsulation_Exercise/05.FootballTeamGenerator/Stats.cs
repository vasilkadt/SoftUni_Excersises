using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Stats
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Stats(int endurance,int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance
        {
            get => endurance;
            private set
            {
                if (IsStatInavlid(value))
                {
                    throw new ArgumentException(String.Format(ExeptionMessages.InvalidStatMessage, nameof(this.Endurance)));
                }
                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
            private set
            {
                if (IsStatInavlid(value))
                {
                    throw new ArgumentException(String.Format(ExeptionMessages.InvalidStatMessage, nameof(this.Sprint)));
                }
                sprint = value;
            }
        }
        public int Dribble
        {
            get => dribble;
            private set
            {
                if (IsStatInavlid(value))
                {
                    throw new ArgumentException(String.Format(ExeptionMessages.InvalidStatMessage, nameof(this.Dribble)));
                }
                dribble = value;
            }
        }
        public int Passing
        {
            get => passing;
            private set
            {
                if (IsStatInavlid(value))
                {
                    throw new ArgumentException(String.Format(ExeptionMessages.InvalidStatMessage, nameof(this.Passing)));
                }
                passing = value;
            }
        }
        public int Shooting
        {
            get => shooting;
            private set
            {
                if (IsStatInavlid(value))
                {
                    throw new ArgumentException(String.Format(ExeptionMessages.InvalidStatMessage, nameof(this.Shooting)));
                }
                shooting = value;
            }
        }
        private bool IsStatInavlid(int value)
          => value < 0 || value > 100;
    }
}
