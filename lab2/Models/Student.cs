using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class Student
    {
        public string Name { get; }
        public string LName { get; }
        public List<Course> Courses { get; }
        public List<Grade> Grades { get; }
        public List<Review> Reviews { get; }

        public Student(string name, string lName, int age)
        {
            this.Name = name;
            this.LName = lName;

            this.Courses = new List<Course>();
            this.Grades = new List<Grade>();
            this.Reviews = new List<Review>();
        }
    }
}