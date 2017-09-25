using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Abp.Timing;
using System;
using Abp.Net.Mail;
using Pro.Persons.Dto;

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


			//IEmailSender emailSender
			//DefaultMailKitSmtpBuilder
			//DefaultFromAddress

			PersonDto personDto = new PersonDto();



			return View();
		}
	}
}