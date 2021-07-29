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
        private static List<Student> students = new List<Student>();
       // servername/SMS/Index
        [Route("DPS/Home")]
        public ActionResult Index()
        {    
            return View();
        }

        public ActionResult ListView()
        {
           // ViewData["myMessage"] = "List of Student Records:";
            ViewBag.myMessage = "List of Student Records:";
            return View(students);
        }
        public ActionResult CreateStudent(Student obj)
        {
            students.Add(obj);
            return RedirectToActionPermanent("Index", "SMS");
          //  return RedirectToAction("Index");
        }
        
    
    }
}