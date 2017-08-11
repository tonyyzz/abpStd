using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Pro.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ProControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}