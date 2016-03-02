using BasicAngular.Net.Models.Registration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicAngular.Net.Controllers
{
    public class CoursesController : Controller
    {
        private RegistrationModelBuilder _registrationModelBuilder = new RegistrationModelBuilder();

        public ActionResult Index()
        {
            return View("Index", "", _registrationModelBuilder.GetSerializedCourses());
        }

        // GET: Hello
        //public ActionResult Index()
        //{
        //    return View("Index", "", GetSerializedCourses());
        //}

        //public string GetSerializedCourses()
        //{
        //    var courses = new[]
        //    {
        //        new CourseModel { Number="CREA101", Name="Care of Magical Creatures", Instructor="Rubues Hagrid" },
        //        new CourseModel { Number="DARK502", Name="Defence Against the Dark Arts", Instructor="Severus Snape" },
        //        new CourseModel { Number="TRAN201", Name="Transfiguration", Instructor="Minerva mcGonagall" }
        //    };
        //    var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
        //    return JsonConvert.SerializeObject(courses, Formatting.None, settings);  
        //    //return courses.ToString(Newtonsoft.Json.Formatting.None);          
        //}
    }

    //public class CourseModel
    //{
    //    public string Number { get; set; }        
    //    public string Name { get; set; }
    //    public string Instructor { get; set; }
    //}
}