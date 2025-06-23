using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace TestSoccer_Player
{
    internal class PlayerWriter
    {
        public static void WritePlayerToScreen(List<SoccerPlayer> players)
        {
            foreach (SoccerPlayer player in players)
            {
                WriteLine($"Player: {player.FirstName} {player.LastName}, Jersey Number: {player.JerseyNumber}, Goals Scored: {player.GoalsScored}, Assists: {player.Assists}");
            }
        }
    }
}