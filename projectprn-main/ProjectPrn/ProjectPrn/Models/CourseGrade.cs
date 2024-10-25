using System;
using System.Collections.Generic;

namespace ProjectPrn.Models
{
    public partial class CourseGrade
    {
        public CourseGrade()
        {
            Grades = new HashSet<Grade>();
        }

        public int CourseGradeId { get; set; }
        public string? GradeName { get; set; }
        public int? CourseId { get; set; }
        public double? Weight { get; set; }

        public virtual Course? Course { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
