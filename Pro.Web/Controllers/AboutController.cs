using System.Web.Mvc;

namespace Pro.Web.Controllers
{
    public class AboutController : ProControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}