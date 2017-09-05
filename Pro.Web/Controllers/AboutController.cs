using System.Web.Mvc;

namespace Pro.Web.Controllers
{
	public class AboutController : ProControllerBase
	{
		public ActionResult Index()
		{
			Logger.Info("------A Info message...");
			Logger.Warn("------A Warn message...");
			Logger.Fatal("------A Fatal message...");
			Logger.Error("------A Error message...");
			Logger.Debug("------A Debug message...");
			return View();
		}
	}
}