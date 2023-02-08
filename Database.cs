using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace ADO.NET_HW6
{
    public class FootballContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FootballDB;Trusted_Connection=True;");
        }
    }
}

