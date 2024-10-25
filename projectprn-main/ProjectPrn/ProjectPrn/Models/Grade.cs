using System;
using System.Collections.Generic;

namespace ProjectPrn.Models
{
    public partial class Grade
    {
        public int GradeId { get; set; }
        public int? ClassId { get; set; }
        public int? CourseGradeId { get; set; }
        public string? StudentId { get; set; }
        public double? Score { get; set; }

        public virtual Class? Class { get; set; }
        public virtual CourseGrade? CourseGrade { get; set; }
        public virtual Student? Student { get; set; }
    }
}
