using System;
using System.Collections.Generic;

namespace ProjectPrn.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Classes = new HashSet<Class>();
        }

        public int TeacherId { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
