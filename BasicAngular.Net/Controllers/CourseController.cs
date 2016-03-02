using BasicAngular.Net.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicAngular.Net.Controllers
{
    public class CourseController : JsonController
    {
        private readonly RegistrationModelBuilder _registrationModelBuilder = new RegistrationModelBuilder();
        // GET: Course
        public ActionResult Index()
        {
            return Json(_registrationModelBuilder.GetCourses(), JsonRequestBehavior.AllowGet);
        }
    }  
}