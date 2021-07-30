using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JulyRadicalMVC.Models;

namespace JulyRadicalMVC.Controllers
{
    public class ValidatorController : Controller
    {
        //
        // GET: /Validator/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveBook(Book obj)
        {
            if (ModelState.IsValid)
            {
                //do my stuff

                return Content("Successfull");
                
            }
            return View("Index");
        }


        public ActionResult DemoPartilaView()
        {
            return View();
        }

	}
}