using JoseStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoseStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Models.Student> students = new List<Models.Student>();
            {
                students.Add(new Models.Student { StudentNumber = 01234567, FName = "Jane", Surname = "Doe", Email = "jane.doe@tuks.co.za" });
                students.Add(new Models.Student { StudentNumber = 12345678, FName = "John", Surname = "Doe", Email = "john.doe@tuks.co.za" });
                students.Add(new Models.Student { StudentNumber = 23708795, FName = "Jose", Surname = "Edu", Email = "jose@tuks.co.za" });
                students.Add(new Models.Student { StudentNumber = 18345689, FName = "Jeff", Surname = "Rizal", Email = "jeff@gmail.com" });
                students.Add(new Models.Student { StudentNumber = 28658477, FName = "Andres", Surname = "Bonifacio", Email = "Andres@gmail.com" });

                return View();
            }
        }
    }
}