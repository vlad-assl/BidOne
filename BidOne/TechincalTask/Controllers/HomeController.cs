using System.Web.Mvc;
using BidOne.TechnicalTask.Lib.Models;

namespace BidOne.TechincalTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult AjaxMethod(Person person)
        {
            Person p = new Person
            {
                FirstName = person.FirstName,
                LastName = person.LastName
            };

            return Json(p);
        }
    }
}