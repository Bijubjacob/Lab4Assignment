using System;
using TestSoccer_Player;

// Compare this snippet from TestSoccer_Player/Program.cs:
namespace TestSoccer_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new team
            Team team = new Team("The Champions", "Biju Jacob");

            // Add players to the team
            team.AddPlayer("Alice", "Smith", 10);
            team.AddPlayer("Bob", "Johnson", 11);
            team.AddPlayer("Charlie", "Brown", 12); 

            // Update player statistics
            team.Players[0].GoalsScored = 5;
            team.Players[0].Assists = 3;
            team.Players[1].GoalsScored = 2;
            team.Players[1].Assists = 4;
            team.Players[2].GoalsScored = 1;
            team.Players[2].Assists = 2;

            // Write the team information to the console
            TeamWriter.WriteTeamToScreen(team);
        }
    }
}
