using JulyRadicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JulyRadicalMVC.Controllers
{
    public class SMSController : Controller
    {
       // servername/SMS/Index
        public ActionResult Index()
        {
            //response can be done in many ways
            //return Content("Hello world");

            Student obj = new Student();
            obj.Id = 101;
            obj.Name = "Rahul";
            obj.Class = 1;

            //return Json(obj, JsonRequestBehavior.AllowGet);

            //return new EmptyResult();

            //return new HttpUnauthorizedResult("Access is denied");

            return View(obj);
        }

        public ActionResult CreateStudent(Student obj)
        {

            return View();
        }
	}
}