using CoachesSoccerCompanionWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoachesSoccerCompanionWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Participant>? Participants { get; set; }
        public DbSet<Coach>? Coaches { get; set; }

        public DbSet<Player>? Players { get; set; }

        public DbSet<Team>? Teams { get; set; }

        public DbSet<PositionTime> PositionTimes { get; set; }

        public DbSet<CoachesSoccerCompanionWeb.Models.PositionTime>? PositionTime { get; set; }

    }
}