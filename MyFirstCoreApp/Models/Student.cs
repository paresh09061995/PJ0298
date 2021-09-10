using System.Collections.Generic;

namespace MyFirstCoreApp.Models
{

    public class commonModel
    {
        public Student studentdata { get; set; }
        public StudentList student { get; set; }
    }
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
    }

    public class StudentList {
        public List<Student> studentList { get; set; }
    }

}