namespace CoachesSoccerCompanionWeb.Models
{
    public enum Position
    {
        GoalKeeper,
        FullBack,
        MidFielder,
        Striker,
        Bench
    };
    public class PositionTime
    {
        public Guid? Id { get; set; }
        public DateTime? PlaytimeStart { get; set; }
        public DateTime? PlaytimeEnd { get; set; }
        public Position? Position { get; set; }
        public double? TimePlayed { get; set; }
        public static double TimePlayedCalc(DateTime PlaytimeStart, DateTime PlaytimeEnd)
        {
            TimeSpan playtime = PlaytimeEnd.Subtract(PlaytimeStart);
            return playtime.TotalSeconds;
        }
    }

    
}
