using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebApi.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			return View();
		}

		[HttpPost]
		public JsonResult CheckIp(object info)
		{
			var k = AntiForgeryConfig.CookieName;
			AntiForgery.Validate();
			//var c = Request.Cookies;
			//var address = Request.UserHostAddress;
			//info.Ip = address;
			return Json(info);
		}
	}
}
