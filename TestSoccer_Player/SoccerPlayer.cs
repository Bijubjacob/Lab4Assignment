using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestSoccer_Player
{
    internal class SoccerPlayer
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }

        private int jerseyNumber { get; set; }
        public int JerseyNumber
        {
            get
            {
                return jerseyNumber;
            }
            set
            {
                if (value < 0 || value > 99)
                {
                    throw new ArgumentOutOfRangeException("Jersey number must be between 0 and 99.");
                }
                jerseyNumber = value;
            }
        }   
        private int goalsScored { get; set; }
        public int GoalsScored
        {
            get
            {
                return goalsScored;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Goals scored cannot be negative.");
                }
                goalsScored = value;
            }
        }   
        private int assists { get; set; }

        public int Assists
        {
            get
            {
                return assists;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Goals scored cannot be negative.");
                }
                assists = value;
            }

        }
        public SoccerPlayer(string firstName, string lastName, int jerseyNumber, int goalsScored, int assists)
        {
            FirstName = firstName;
            LastName = lastName;
            JerseyNumber = jerseyNumber;
            GoalsScored = goalsScored;
            Assists = assists;
        }

        public int TotalGoals(int goals)
        {
            if (goals < 0)
            {
                throw new ArgumentOutOfRangeException("Goals cannot be negative.");
            }
            GoalsScored += goals;
            return GoalsScored;
        }

        public int TotalAssists(int assists)
        {
            if (assists < 0)
            {
                throw new ArgumentOutOfRangeException("Assists cannot be negative.");
            }
            Assists += assists;
            return Assists;
        }

        public override string ToString()
        {
            return $"{FirstName}\t{LastName}\t, Jersey Number: {JerseyNumber}\t, Goals Scored: {GoalsScored}\t, Assists: {Assists}\t";
        }
    }
}
