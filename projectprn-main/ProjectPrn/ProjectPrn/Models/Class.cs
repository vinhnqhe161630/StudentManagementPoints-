using System;
using System.Collections.Generic;

namespace ProjectPrn.Models
{
    public partial class Class
    {
        public Class()
        {
            Grades = new HashSet<Grade>();
            StudentClasses = new HashSet<StudentClass>();
        }

        public int ClassId { get; set; }
        public string? Name { get; set; }
        public int? Status { get; set; }
        public int? Semester { get; set; }
        public int? TeacherId { get; set; }
        public int? CourseId { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
        public string ClassAndCourse
        {
            get { return Name + " / " + (Course != null ? Course.Name : ""); }
        }
        public string CourseName
        {
            get { return Course.Name; }
        }


    }
}
