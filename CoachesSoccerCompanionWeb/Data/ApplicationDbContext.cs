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

        protected override void OnModelCreating(ModelBuilder modelBuilder1)
        {
            modelBuilder1.Entity<Coach>().HasData(new Coach
            {
                Id = Guid.Parse("c7012bd4-79ae-4835-be3f-3bf3fc43c60e"),
                FirstName = "CoachSeedFirstName",
                LastName = "CoachSeedLastName",
                PhoneNumber = "555-555-5555"
            });

            base.OnModelCreating(modelBuilder1);

        }
    }
}