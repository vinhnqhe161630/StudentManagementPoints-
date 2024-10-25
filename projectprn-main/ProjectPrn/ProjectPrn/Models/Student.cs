using System;
using System.Collections.Generic;

namespace ProjectPrn.Models
{
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
            StudentClasses = new HashSet<StudentClass>();
        }

        public string StudentId { get; set; } = null!;
        public string? Email { get; set; }
        public string? Comment { get; set; }
        public string? Name { get; set; }
        public DateTime? Dob { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
       
    }
}
