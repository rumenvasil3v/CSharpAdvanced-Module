using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator.Models
{
    public class Player
    {
        private const string NameException = "A name should not be empty.";
        private const string SkillValueException = " should be between 0 and 100.";
        private const double NumberOfStats = 5;

        private const int SkillMinValue = 0;
        private const int SkillMaxValue = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                IsNameInvalid(value);
                this.name = value;
            }
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                IsSkillValueInvalid(value, nameof(this.Endurance));
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => this.sprint;
            private set
            {
                IsSkillValueInvalid(value, nameof(this.Sprint));
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            private set
            {
                IsSkillValueInvalid(value, nameof(this.Dribble));
                this.dribble = value;
            }
        }

        public int Passing
        {
            get => this.passing;
            private set
            {
                IsSkillValueInvalid(value, nameof(this.Passing));
                this.passing = value;
            }
        }

        public int Shooting
        {
            get => this.shooting;
            private set
            {
                IsSkillValueInvalid(value, nameof(this.Shooting));
                this.shooting = value;
            }
        }

        public double SkillLevel => CalculateSkillLevel();

        private double CalculateSkillLevel()
        {
            return (this.Shooting + this.Passing + this.Dribble + this.Sprint + this.Endurance) / NumberOfStats;
        }

        private void IsNameInvalid(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(NameException);
            }
        }

        private void IsSkillValueInvalid(int value, string skill)
        {
            if (value < SkillMinValue || value > SkillMaxValue)
            {
                throw new ArgumentException(skill + SkillValueException);
            }
        }
    }
}