using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoseStudyGroup.Models
{
	public class Student
	{
        [Display(Name = "STUDENT NUMBER")]
        public int StudentNumber { get; set; }

        [Display(Name = "NAME")]
        public string FName { get; set; }

        [Display(Name = "SURNAME")]
        public string Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string Email { get; set; }

    }
}