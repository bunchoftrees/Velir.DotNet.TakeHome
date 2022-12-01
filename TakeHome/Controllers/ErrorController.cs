using System;
using System.Web.Mvc;

namespace TakeHome.Controllers
{
	public class ErrorController : Controller
    {
		[HandleError]
		public ActionResult Index()
		{
			return View("Error");
		}
	}
}

