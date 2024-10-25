using ProjectPrn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPrn
{
    internal class ValidateMark
    {
        GradeService gradeService = new GradeService();
        private void ValidateAndUpdateGrade(Grade gradeChange, string cellValue)
        {
            try
            {
                if (float.TryParse(cellValue, out float a))
                {
                    if (a >= 1 && a <= 10)
                    {
                        gradeService.updateGrade(gradeChange, a);
                    }
                    else
                    {
                        MessageBox.Show("Nhập số từ 1 - 10");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

    }
}
