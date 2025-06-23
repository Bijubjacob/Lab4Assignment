using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestSoccer_Player
{
    internal class Team
    {
        public string Name { get; set; }
        public string Coach { get; set; }
        public List<SoccerPlayer> Players { get; private set; }

        public Team(string name, string coach)
        {
            Name = name;
            Coach = coach;
            Players = new List<SoccerPlayer>();
        }

        public SoccerPlayer AddPlayer(string firstName, string lastName, int jerseyNumber)
        {
            SoccerPlayer player = new SoccerPlayer(firstName, lastName, jerseyNumber, 0, 0);
            Players.Add(player);
            return player;
        }
        public int CalculateTotalGoals()
        {
            int totalGoals = 0;
            foreach (SoccerPlayer player in Players)
            {
                totalGoals += player.GoalsScored;
            }
            return totalGoals;
        }
        public int CalculateTotalAssists()
        {
            int totalAssists = 0;
            foreach (SoccerPlayer player in Players)
            {
                totalAssists += player.Assists;
            }
            return totalAssists;
        }
    }
}
