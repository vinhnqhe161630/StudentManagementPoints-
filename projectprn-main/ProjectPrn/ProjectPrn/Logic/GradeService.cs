using Microsoft.EntityFrameworkCore;
using ProjectPrn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPrn
{
    
    internal class GradeService
    {
        StudentService studentService= new StudentService();
        ProjectPRN5Context _context = new ProjectPRN5Context();


        public void SaveChange()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error updating the database: " + ex.Message, "Database Error");
            }
        }
        public List<Grade> GetListGrades(int courseGradeId,int classId,string studentId)
        {
            var query = _context.Grades.Include(c => c.Class)
                                .Include(c => c.Class)
                                .Include(c => c.Student)
                                .Where(c => c.ClassId == classId && c.CourseGradeId == courseGradeId);

            if (!string.IsNullOrEmpty(studentId))
            {
                query = query.Where(c => c.StudentId == studentId);
            }

            return query.ToList();
        }
        public Grade GetListGradesOfStudent(int courseGradeId, int classId,string StudentId)
        {
            return _context.Grades
     .Include(c => c.Class)
       .Include(c => c.Class).Include(c => c.Student)
     .FirstOrDefault(c => c.ClassId == classId && c.CourseGradeId == courseGradeId && c.StudentId == StudentId);
    
        }

        public void updateGrade(Grade grade,float? a)
        {
            if (grade != null)
            {
                grade.Score = a;
                _context.SaveChanges();
            }
            }

        public void addNewGradeForcourseGrade(int classId,int courseGrandeId)
        {
           List<Student> studens = studentService.getStudentinClass(classId);
            foreach (Student student in studens)
            {
                Grade grade = new Grade
                {
                    ClassId = classId,
                    CourseGradeId = courseGrandeId,
                    StudentId = student.StudentId,
                    Score = null
                };
                _context.Grades.Add(grade);
               
            }
            _context.SaveChanges();
        }
    }
   
}
