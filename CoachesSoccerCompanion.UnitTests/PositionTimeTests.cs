using CoachesSoccerCompanionWeb.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Net;

namespace CoachesSoccerCompanion.UnitTests
{
    [TestClass]
    public class PositionTimeTests
    {
        [TestMethod]
        public void TimePlayedCalc_ValidInput_PlaytimeReturned()
        {
            //Arrange
            var positiontime = new PositionTime();

            //Act
            var now = DateTime.Now;
            positiontime.PlaytimeStart = now;
            positiontime.PlaytimeEnd = now.AddMinutes(5.0);
            var result = PositionTime.TimePlayedCalc((DateTime)positiontime.PlaytimeStart,(DateTime)positiontime.PlaytimeEnd);

            //Assert
            Assert.IsInstanceOfType(result, typeof(Double));
        }
    }
}