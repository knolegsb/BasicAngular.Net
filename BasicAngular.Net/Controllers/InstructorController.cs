using BasicAngular.Net.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicAngular.Net.Controllers
{
    public class InstructorController : JsonController
    {
        private readonly RegistrationModelBuilder _registrationModelBuilder = new RegistrationModelBuilder();

        public ActionResult Index()
        {
            return Json(_registrationModelBuilder.GetInstructors(), JsonRequestBehavior.AllowGet);
        }
    }
}