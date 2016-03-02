using BasicAngular.Net.Models.Instructors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAngular.Net.Models.Registration
{
    public class RegistrationModelBuilder
    {
        public RegistrationModel BuildRegistrationModel()
        {
            var registrations = new RegistrationModel
            {
                Courses = GetSerializedCourses(),
                Instructors = GetSerializedInstructors()
            };
            return registrations;
        }

        public string GetSerializedCourses()
        {
            var courses = new[]
                {
                    new CourseModel {Number = "CREA101", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
                    new CourseModel {Number = "DARK502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
                    new CourseModel {Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall"},
                };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializedCourses = JsonConvert.SerializeObject(courses, Formatting.None, settings);
            return serializedCourses;
        }

        public string GetSerializedInstructors()
        {
            var instructors = new[]
                {
                    new InstructorModel {Name = "Rubeus Hagrid", Email = "hagrid@hogwarts.com", RoomNumber = 1001},
                    new InstructorModel {Name = "Severus Snape", Email = "snape@hogwarts.com", RoomNumber = 105},
                    new InstructorModel {Name = "Minerva McGonagall", Email = "mcgonagall@hogwarts.com", RoomNumber = 102},
                };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializedInstructors = JsonConvert.SerializeObject(instructors, Formatting.None, settings);
            return serializedInstructors;
        }
    }
}