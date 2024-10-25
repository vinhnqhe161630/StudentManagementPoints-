using ProjectPrn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPrn
{
    public class StudentService
    {

        ProjectPRN5Context _context = new ProjectPRN5Context();
        public List<Student> getStudentinClass(int classID)
        {
            var studentsInClass = (from sc in _context.StudentClasses
                                   join s in _context.Students on sc.StudentId equals s.StudentId
                                   where sc.ClassId == classID
                                   select s).ToList();
            return studentsInClass;
        }
        public Student getStudentById(string StudentId)

        {
            return _context.Students.FirstOrDefault(x => x.StudentId == StudentId);
        }
        public bool IsStudentInClass(string studentId, int classId)
        {
            bool isPresent = _context.StudentClasses
                                    .Any(sc => sc.ClassId == classId && sc.StudentId == studentId);
            return isPresent;
        }

        public void addStudentInClass(string studentId, int classId)
        {
         StudentClass newStudentClass = new StudentClass
        {
            StudentId = studentId,
            ClassId = classId
        };
            _context.StudentClasses.Add(newStudentClass);
            _context.SaveChanges();
        }

        public void addGradeforStudent(string studentId, int classId,int courseGradeId)
        {
            Grade grade = new Grade
            {
                StudentId = studentId,
                ClassId = classId,
                CourseGradeId = courseGradeId,
                Score = null
            };
            _context.Grades.Add(grade);
            _context.SaveChanges();
        }
       

      
    }
}
