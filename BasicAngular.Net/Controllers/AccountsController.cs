using BasicAngular.Net.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BasicAngular.Net.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        [HttpPost]
        public ActionResult Save(StudentModel student)
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}