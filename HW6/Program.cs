using System;
using Microsoft.EntityFrameworkCore;

namespace FootballTournamentTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FootballContext())
            {
                 
                context.Database.EnsureCreated();

                
                context.Teams.Add(new Team { Name = "Barcelona", City = "Barcelona", Wins = 22, Losses = 5, Draws = 3 });
                context.Teams.Add(new Team { Name = "Real Madrid", City = "Madrid", Wins = 21, Losses = 6, Draws = 3 });
                context.Teams.Add(new Team { Name = "Atletico Madrid", City = "Madrid", Wins = 19, Losses = 8, Draws = 5 });
                context.SaveChanges();

                 
                Console.WriteLine("Teams:");
                foreach (var team in context.Teams)
                {
                    Console.WriteLine($"Name: {team.Name}, City: {team.City}, Wins: {team.Wins}, Losses: {team.Losses}, Draws: {team.Draws}");
                }
            }
        }
    }
}

}