using System;
using System.Collections.Generic;

namespace ProjectPrn.Models
{
    public partial class Course
    {
        public Course()
        {
            Classes = new HashSet<Class>();
            CourseGrades = new HashSet<CourseGrade>();
        }

        public int CourseId { get; set; }
        public string? Name { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<CourseGrade> CourseGrades { get; set; }
      
    }
}
