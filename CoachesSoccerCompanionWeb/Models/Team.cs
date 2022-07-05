namespace CoachesSoccerCompanionWeb.Models
{
    public class Team
    {
        public Guid? Id { get; set; }

        public string? Name { get; set; }
        public Coach? Coach { get; set; }

        public List<Player>? Players { get; set; }

    }
}
