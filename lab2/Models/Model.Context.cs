﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CourseDbEntities : DbContext
    {
        public CourseDbEntities()
            : base("name=CourseDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonCourse> PersonCourses { get; set; }
        public virtual DbSet<PersonGrade> PersonGrades { get; set; }
        public virtual DbSet<StudentView> StudentViews { get; set; }
        public virtual DbSet<TeacherView> TeacherViews { get; set; }
    }
}
