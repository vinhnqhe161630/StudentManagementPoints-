using Microsoft.EntityFrameworkCore;
using ProjectPrn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPrn
{
    public class ClassService
    {
        ProjectPRN5Context _context = new ProjectPRN5Context();
        public List<Class> getAllClass(int id)
        {
            try
            {
  return _context.Classes.Include(c => c.Course).Where(x => x.TeacherId ==id).ToList();
            }catch (Exception ex)
            {
                return null;
            }
          
        }
        public Class getClassById(int id)
        {
            return _context.Classes.Include(c => c.Course).FirstOrDefault(c => c.ClassId == id);
        }
        public Teacher GetTeacherbyId(int id)
        {
            return _context.Teachers.FirstOrDefault(x => x.TeacherId == id);
        }

    }
}
