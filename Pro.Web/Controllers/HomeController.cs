using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Abp.Timing;
using System;

namespace Pro.Web.Controllers
{
	[AbpMvcAuthorize]
	public class HomeController : ProControllerBase
	{
		public ActionResult Index()
		{
			Clock.Provider = ClockProviders.Utc;
			var datetime = Clock.Now;
			var datetimeKind = Clock.Kind;
			var flag = Clock.SupportsMultipleTimezone;
			var time = Clock.Normalize(datetime);



			return View();
		}
	}
}