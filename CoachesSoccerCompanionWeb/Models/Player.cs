using System.ComponentModel.DataAnnotations;

namespace CoachesSoccerCompanionWeb.Models
{
    public class Player : Participant
    {
       
        public List<PositionTime>? PositionTimes { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
       
        
        /*public Player(string? firstname, string? lastname, DateTime? dateofbirth) : base(firstname, lastname)
        {
            DateOfBirth = dateofbirth;
            this.FirstName = firstname;
            this.LastName = lastname;
        }*/
    }
}
