using Microsoft.AspNetCore.Mvc;
using MyFirstCoreApp.Models;
using System.Collections.Generic;
namespace MyFirstCoreApp.Controllers
{
    public class HomeController : Controller
    {
        List<Student> lstStudent =  new List<Student>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(commonModel model)
        {
            model.student = new StudentList();
            model.student.studentList = LoadData(model.studentdata);
            return View(model);
        }

        public List<Student> LoadData(Student model) {
            Student student = new Student();
            if (model != null) {
                student.RollNo = model.RollNo;
                student.Name = model.Name;
                student.Class = model.Class;
                lstStudent.Add(student); 
            }
            return lstStudent;
        }
    }
}