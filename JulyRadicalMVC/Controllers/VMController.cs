using JulyRadicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JulyRadicalMVC.Controllers
{
    public class VMController : Controller
    {
        //
        // GET: /VM/
        public ActionResult Index()
        {
            Address RameshAddress = new Address();
            RameshAddress.Addresss_one = "Sapna apartment";
            RameshAddress.City = "Mumbai";
            RameshAddress.State = "Maharashtra";

            var RakeshAddress = new Address() 
            { 
                Addresss_one="Aakash apt",
                City="Nagpur",
                State="Maharashtra"
            };

            Student ramesh = new Student()
            {
                Name = "Ramesh",
                Id = 101,
                Class = 1,
                address = RameshAddress

            };

            Student rakesh = new Student()
            {
                Name = "Rakesh",
                Id = 102,
                Class = 2,
                address = RakeshAddress

            };

            List<Student> students = new List<Student>() 
            {
               ramesh,
               rakesh
            };

            return View(students);
        }

        [HandleError]
        [HandleError(ExceptionType=typeof(NullReferenceException),View="~/Views/Shared/NullReferenceException.cshtml")]
        public ActionResult MySample()
        {
            int a, b, c;
            a = 10; b = 0;
            c = a / b;
            //string msg = null;
            //ViewBag.MyData = msg.Length;
            return Content("hello");//msg.Length.ToString());
        }
	}
}