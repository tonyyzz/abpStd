using System.Web.Mvc;

namespace Pro.Web.Controllers
{
	public class AboutController : ProControllerBase
	{
		public ActionResult Index()
		{
			Logger.Debug("A sample log message...");
			return View();
		}
	}
}