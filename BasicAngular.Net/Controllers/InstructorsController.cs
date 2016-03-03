using BasicAngular.Net.Models.Instructors;
using BasicAngular.Net.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace BasicAngular.Net.Controllers
{
    public class InstructorsController : ApiController
    {
        private readonly RegistrationModelBuilder _registrationModelBuilder = new RegistrationModelBuilder();

        public InstructorModel[] Get()
        {
            return _registrationModelBuilder.GetInstructors();
        }
    }
}
