using Fruits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MVC_Auth.Controllers
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

		
		[HttpGet]
		public ActionResult TestForm()
		{
			return View(new VisitInfo());
		}

		[HttpPost]
		public JsonResult CheckIp(VisitInfo info)
		{
			var k = AntiForgeryConfig.CookieName;
			AntiForgery.Validate();
			var c = Request.Cookies;
			var address = Request.UserHostAddress;
			info.Ip = address;
			return Json(info);
		}
	}
}