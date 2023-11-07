using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator.Models
{
    public class Team
    {
        private const string NameException = "A name should not be empty.";
        private const string PlayerException = "Player {0} is not in {1} team.";

        private string name;
        private Dictionary<string, Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new Dictionary<string, Player>();
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

        public double Rating => CalculateRatingOfTheTeam();

        public void AddPlayer(Player player)
        {
            this.players.Add(player.Name, player);
        }

        public void RemovePlayer(string playerName)
        {
            DoesPlayersContainPlayerName(playerName);
            this.players.Remove(playerName);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }

        private double CalculateRatingOfTheTeam()
        {
            double averageSkillOfAllPlayers = 0;
            foreach (var player in this.players)
            {
                averageSkillOfAllPlayers += player.Value.SkillLevel;
            }

            return Math.Round(averageSkillOfAllPlayers);
        }

        private void IsNameInvalid(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(NameException);
            }
        }

        private void DoesPlayersContainPlayerName(string playerName)
        {
            if (!this.players.ContainsKey(playerName))
            {
                throw new ArgumentException(string.Format(PlayerException, playerName, this.Name));
            }
        }
    }
}