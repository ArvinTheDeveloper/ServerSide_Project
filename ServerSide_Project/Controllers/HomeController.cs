using System.Web.Mvc;

namespace ServerSide_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Books()
        {
            return View();
        }

        public ActionResult Author()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}