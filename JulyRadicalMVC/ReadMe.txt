 //response can be done in many ways
            //return Content("Hello world");

            Student obj = new Student();
            obj.Id = 101;
            obj.Name = "Rahul";
            obj.Class = 1;

            //return Json(obj, JsonRequestBehavior.AllowGet);

            //return new EmptyResult();

            //return new HttpUnauthorizedResult("Access is denied");