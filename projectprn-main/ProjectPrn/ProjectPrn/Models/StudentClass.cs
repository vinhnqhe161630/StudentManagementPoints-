using System;
using System.Collections.Generic;

namespace ProjectPrn.Models
{
    public partial class StudentClass
    {
        public int StudentClassId { get; set; }
        public int? ClassId { get; set; }
        public string? StudentId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Student? Student { get; set; }
    }
}
