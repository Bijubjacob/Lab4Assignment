using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestSoccer_Player
{
    internal class TeamWriter
    {
        public static void WriteTeamToScreen(Team team)
        {
            WriteLine($"Team: {team.Name}, Coach: {team.Coach}");
            WriteLine();
            PlayerWriter.WritePlayerToScreen(team.Players);
            WriteLine($"Total Goals: {team.CalculateTotalGoals()}");
            WriteLine($"Total Assists: {team.CalculateTotalAssists()}");
        }
    }
}