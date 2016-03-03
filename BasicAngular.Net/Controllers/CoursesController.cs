using BasicAngular.Net.Models;
using BasicAngular.Net.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Mvc;

namespace BasicAngular.Net.Controllers
{
    public class CoursesController : ApiController
    {
        private readonly RegistrationModelBuilder _registrationModelBuilder = new RegistrationModelBuilder();

        public CourseModel[] Get()
        {
            //return Json(_registrationModelBuilder.GetCourses(), JsonRequestBehavior.AllowGet);
            // Web Api already takes care of converting your objects from their native
            //Thread.Sleep(5000);
            return _registrationModelBuilder.GetCourses();
        }
    }
}
