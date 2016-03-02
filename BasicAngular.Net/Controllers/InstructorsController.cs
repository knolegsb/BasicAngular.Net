using BasicAngular.Net.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicAngular.Net.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly RegistrationModelBuilder _registrationModelBuilder = new RegistrationModelBuilder();
        // GET: Registrations
        public ActionResult Index()
        {
            return View("Index", "", _registrationModelBuilder.GetSerializedInstructors());
        }
    }
}