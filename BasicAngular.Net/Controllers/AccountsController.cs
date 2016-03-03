using BasicAngular.Net.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BasicAngular.Net.Controllers
{
    //public class AccountsController : Controller
    public class AccountsController : ApiController
    {
        
        //[HttpPost]
        //public ActionResult Save(StudentModel student)
        //{
        //    return new HttpStatusCodeResult(HttpStatusCode.OK);
        //}

        public HttpResponseMessage Post(HttpRequestMessage request, StudentModel student)
        {
            if (ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessages());
        }

        private IEnumerable<string> GetErrorMessages()
        {
            return ModelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage));
        }
    }
}