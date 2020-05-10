using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class Grade
    {
        public int StudentGrade { get; }
        public string TeacherReview { get; }
        public Teacher Teacher { get; }
        public Student Student { get; }

        public Grade(int grade, string review, Teacher teacher, Student student)
        {
            this.StudentGrade = grade;
            this.TeacherReview = review;
            this.Teacher = teacher;
            this.Student = student;
        }
    }
}