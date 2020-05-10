using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class Course
    {
        public string Name { get; }
        public List<Student> Students { get; }
        [ForeignKey("Teachers.Course")]
        public Teacher Teacher { get; }

        public Course(string name, Teacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Students = new List<Student>();
        }
    }
}