using ProjectPrn.Logic;
using ProjectPrn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPrn
{
    public partial class ManageCourse : Form
    {
        ClassService classService = new ClassService();
        StudentService studentService = new StudentService();
        CourseService courseService = new CourseService();
        GradeService gradeService = new GradeService();
        ProjectPRN5Context _context = new ProjectPRN5Context();
        List<CourseGrade> courses;
        CourseGrade courseGrade;
        int courseId;
        int tid = 0;
        public void SetTearchID(int id)
        {
            tid = id;
        }
        public ManageCourse()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ManageClass_Load(object sender, EventArgs e)
        {


            courseList.DisplayMember = "Name";
            courseList.ValueMember = "CourseId";
            List<Course> coursesList = courseService.GetCourses();
            courseList.DataSource = coursesList;
            LoadData();

        }

        public void LoadData()
        {


            courseId = Convert.ToInt32(courseList.SelectedValue);

            if (courseId != null)
            {
                courses = courseService.getListCourseGrade(courseId);
                var coureGrades = courseService.getListCourseGrade(courseId).Select(x => new
                {
                    Name = x.GradeName,
                    Weight = x.Weight
                }
).ToList();
                dataGridView1.DataSource = coureGrades;


            }




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;

            }
            courseGrade = courses[e.RowIndex];
            if (courseGrade != null)
            {
                grade.Text = courseGrade.GradeName;
                weight.Value = Convert.ToDecimal(courseGrade.Weight);
            }





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add 
            string nameGrade = grade.Text;
            double weightAdd = Convert.ToDouble(weight.Value);
            double totalpercent = 0;
            if (courses.Count > 0)
            {
                foreach (CourseGrade grade in courses)
                {
                    if (grade != null)
                    {
                        totalpercent = Convert.ToDouble(grade.Weight) + totalpercent;
                    }

                }
            }

            CourseGrade courseGrade = courseService.GetCourseGradeByName(courseId, nameGrade);
            if (courseGrade != null)
            {
                MessageBox.Show("Grade Name exited !");
            }
            else if (totalpercent == 100 || (totalpercent + weightAdd) > 100)
            {
                MessageBox.Show("Total process percentage more than 100% !");
            }
            else
            {
                CourseGrade newcourseGrade = new CourseGrade
                {
                    GradeName = nameGrade,
                    CourseId = courseId,
                    Weight = weightAdd,

                };
                courseService.AddnewCourseGrade(newcourseGrade);
                grade.Text = String.Empty;
                weight.Value = 0;

            }
            LoadData();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grade.Text = String.Empty;
            weight.Value = 0;
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameGrade = grade.Text;
            double weightAdd = Convert.ToDouble(weight.Value);
            double totalpercent = 0;
            if (courses.Count > 0)
            {
                foreach (CourseGrade grade in courses)
                {
                    if (grade.GradeName == courseGrade.GradeName)
                    {
                        continue;
                    }
                    if (grade != null)
                    {
                        totalpercent = Convert.ToDouble(grade.Weight) + totalpercent;
                    }


                }
            }

            if (!string.IsNullOrEmpty(nameGrade))
            {
                CourseGrade courseGrade1 = courseService.GetCourseGradeByName(courseId, nameGrade);
                if (courseGrade1 != null && courseGrade.GradeName != nameGrade)
                {
                    MessageBox.Show("Grade Name exited!.Please re-input");

                }
                else if (totalpercent + weightAdd > 100)
                {
                    MessageBox.Show("Total process percentage more than 100% !");

                }
                else if (totalpercent + weightAdd <= 100 && !string.IsNullOrEmpty(nameGrade))
                {
                    CourseGrade courseGradeEdit = new CourseGrade
                    {
                        CourseGradeId = courseGrade.CourseGradeId,
                        GradeName = nameGrade,
                        Weight = weightAdd,

                    };

                    courseService.EditCourseGrade(courseGradeEdit);
                }


            }


            LoadData();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nameGrade = grade.Text;
            CourseGrade courseGrade1 = courseService.GetCourseGradeByName(courseId, nameGrade);
            if (courseGrade1 != null)
            {
                courseService.DeleteCourseGrade(courseGrade1);
                MessageBox.Show("Delete Suscessful");
            }
            else
            {
                MessageBox.Show("Delete Failed!");

            }
            grade.Text = String.Empty;
            weight.Value = 0;

            LoadData();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.SetTearchID(tid);
            mainForm.Show();
            this.Hide();
        }

        private void courseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

