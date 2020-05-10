using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class Teacher
    {
        public string Name { get; }
        public string LName { get; }
        [Key]
        public Course Course { get; }

        public Teacher(string name, string lName, int age)
        {
            this.Name = name;
            this.LName = lName;
        }
    }
}