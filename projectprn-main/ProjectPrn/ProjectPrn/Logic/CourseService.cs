using Microsoft.EntityFrameworkCore;
using ProjectPrn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPrn.Logic
{
    internal class CourseService
    {
        ProjectPRN5Context _context = new ProjectPRN5Context();


        public List<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }
        public List<CourseGrade> getListCourseGrade(int? courseId)
        {
            return _context.CourseGrades.Where(c => c.CourseId == courseId).ToList();

        }
        public CourseGrade GetCourseGradeByName(int courseId, string gradename)
        {
            return _context.CourseGrades.FirstOrDefault(x => x.GradeName == gradename && x.CourseId == courseId);



        }
        public void AddnewCourseGrade(CourseGrade coursegrade)
        {
            _context.CourseGrades.Add(coursegrade);
            _context.SaveChanges();

        }
        public void EditCourseGrade(CourseGrade c)
        {

            var course = _context.CourseGrades.FirstOrDefault(co => co.CourseGradeId == c.CourseGradeId);

            if (course != null)
            {

                course.Weight = c.Weight;
                course.GradeName = c.GradeName;


                _context.SaveChanges();
            }

        }
        public void DeleteCourseGrade(CourseGrade c)
        {
            _context.CourseGrades.Remove(c);
            _context.SaveChanges();
        }
    }
}
