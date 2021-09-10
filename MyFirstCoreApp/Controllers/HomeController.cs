using Microsoft.AspNetCore.Mvc;
using MyFirstCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { RollNo = 1, Name = "Paresh", Class = "A" });
            Student student = new Student();
            student.RollNo = 2;
            student.Name = "ABC";
            student.Class = "B";
            students.Add(student);
            ViewData["students"] = students;
            return View();
        }
    }
}
