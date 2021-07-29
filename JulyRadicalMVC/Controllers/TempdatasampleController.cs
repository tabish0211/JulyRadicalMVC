using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JulyRadicalMVC.Controllers
{
    public class TempdatasampleController : Controller
    {
        //
        // GET: /Tempdatasample/Index
        public ActionResult Index()
        {
            TempData["test"] = "Hello world";
            return RedirectToAction("MyAction");
        }

        public ActionResult MyAction()
        {
            TempData["test"] = "Welcome to "+TempData["test"];
            TempData.Keep();
            return View();
        }

        public ActionResult SessionDemo()
        {
            Session["myData"] = "my session object";
            return View();
        }

        public ActionResult AnotherAction()
        {
            return View();
        }
	}
}