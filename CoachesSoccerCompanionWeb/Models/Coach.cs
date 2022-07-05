namespace CoachesSoccerCompanionWeb.Models
{
    public class Coach : Participant
    {
        public string? PhoneNumber { get; set; }

        /*public Coach(string? firstname, string? lastname, string? phonenumber) : base(firstname, lastname)
        {
            this.PhoneNumber = phonenumber;
            this.FirstName = firstname;
            this.LastName = lastname;
        }*/
    }
}
