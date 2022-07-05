namespace CoachesSoccerCompanionWeb.Models
{
    public class Participant
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

       /* public Participant(string? firstname, string? lastname)
        {
            Id = Guid.NewGuid();
            this.FirstName = firstname;
            this.LastName = lastname;
        }*/
    }

}
