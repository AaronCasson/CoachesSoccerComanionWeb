namespace CoachesSoccerCompanionWeb.Models
{
    public class Player : Participant
    {
        private DateTime? dateofbirth;
        public List<PositionTime>? PositionTimes { get; set; }

        public DateTime? DateOfBirth
        {
            get { return dateofbirth; }
            set
            {
                try { dateofbirth = value; }
                catch (Exception FormatException)
                {
                    Console.WriteLine("Oops, we didn't expect this error with the birthdate you entered, sorry!.");
                }
            }
        }
        /*public Player(string? firstname, string? lastname, DateTime? dateofbirth) : base(firstname, lastname)
        {
            DateOfBirth = dateofbirth;
            this.FirstName = firstname;
            this.LastName = lastname;
        }*/
    }
}
