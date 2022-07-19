using CoachesSoccerCompanionWeb.Models;
using System.Web.Mvc;

namespace CoachesSoccerCompanionWeb.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttons = new List<ButtonModel>();
        // GET: Button
        public ActionResult Index()
        {

            buttons.Add(new ButtonModel(true));

            return View("Index", buttons);
        }
        public ActionResult HandleButtonClick(string switchy)
        {
            int buttonNumber = Int32.Parse(switchy);
            buttons[buttonNumber].State = !buttons[buttonNumber].State;
            return View("Index", buttons);
        }
    }
}
