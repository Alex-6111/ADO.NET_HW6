using System;

namespace ADO.NET_HW6
{
    public class TournamentTable
    {
        public string TeamName { get; set; }
        public string City { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }

        public TournamentTable(string teamName, string city, int wins, int losses, int draws)
        {
            TeamName = teamName;
            City = city;
            Wins = wins;
            Losses = losses;
            Draws = draws;
        }
    }
}
