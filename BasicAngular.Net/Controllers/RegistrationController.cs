﻿using BasicAngular.Net.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicAngular.Net.Controllers
{
    public class RegistrationController : Controller
    {
       

        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
    }
}