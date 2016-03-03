using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicAngular.Net.Models.Student
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Please enter a First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter an email address")]
        [RegularExpression(@"^[a-zA-Z0-9'._%+-]+@[a-zA-Z0-9-][a-zA-Z0-9.-]*\.[a-zA-Z]{2,9}$", ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a Password")]
        public string password { get; set; }
    }
}