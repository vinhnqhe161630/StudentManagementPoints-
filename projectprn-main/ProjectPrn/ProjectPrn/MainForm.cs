using ProjectPrn.Logic;
using ProjectPrn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectPrn
{
    public partial class MainForm : Form
    {
        ClassService classService = new ClassService();
        StudentService studentService = new StudentService();
        CourseService courseService = new CourseService();
        GradeService gradeService = new GradeService();
        Class class1 = new Class();
        int tid = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        public void SetTearchID(int id)
        {
            tid = id;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            Teacher te = classService.GetTeacherbyId(tid);
            if (te != null)
            {
                nameTeacher.Text = "Teacher :" + te.Name;
            }

            subject_Class.DisplayMember = "ClassAndCourse";
            subject_Class.ValueMember = "ClassId";
            List<Class> listClass = classService.getAllClass(tid);
            if (listClass.Count > 0)
            {
                subject_Class.DataSource = listClass;
            }



            LoadData();
        }
        public void LoadData()
        {
            int ClassId = Convert.ToInt32(subject_Class.SelectedValue);
            string StudentID = rollNumber.Text;



            if (ClassId != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                var students = studentService.getStudentinClass(ClassId).Select(x => new
                {
                    StudentId = x.StudentId,
                    Name = x.Name,

                }).ToList();


                class1 = classService.getClassById(ClassId);
                List<CourseGrade> courseGrades = courseService.getListCourseGrade(class1.Course.CourseId);

                dataGridView1.DataSource = students;
                if (courseGrades.Count > 0)
                {
                    int yOffset = 20;
                    groupBox1.Controls.Clear();
                    /* Xử lí check box trong groupbox*/
                    AddShowAllCheckBox();
                    foreach (var coursegrade in courseGrades)
                    {
                        AddCheckBox(coursegrade, yOffset, ClassId);
                        yOffset += 50;
                    }
                }

            }
        }

        private void AddShowAllCheckBox()
        {
            CheckBox checkBoxAll = new CheckBox();
            checkBoxAll.Text = "Show All";
            checkBoxAll.AutoSize = true;
            checkBoxAll.Location = new Point(25, 510);
            groupBox1.Controls.Add(checkBoxAll);

            checkBoxAll.CheckedChanged += ShowAllCheckBox_CheckedChanged;
        }

        private void ShowAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý khi checkbox "Show All" được chọn
            CheckBox checkBoxAll = (CheckBox)sender;
            if (checkBoxAll.Checked)
            {

                foreach (Control control in groupBox1.Controls)
                {
                    if (control is CheckBox && control != checkBoxAll)
                    {
                        ((CheckBox)control).Checked = true;
                    }
                }

            }
            else
            {
                foreach (Control control in groupBox1.Controls)
                {
                    if (control is CheckBox && control != checkBoxAll)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }

            }
        }

        private void AddCheckBox(CourseGrade grade, int yOffset, int ClassId)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Text = grade.GradeName;
            checkBox.AutoSize = true;
            checkBox.Location = new Point(20, yOffset);
            groupBox1.Controls.Add(checkBox);

            checkBox.CheckedChanged += (sender, e) => CheckBox_CheckedChanged(sender, e, grade, ClassId);
        }

        /* Xử lí khi checkbox thay đổi trạng thái*/
        private void CheckBox_CheckedChanged(object sender, EventArgs e, CourseGrade coursegrade, int ClassId)
        {
            CheckBox checkBox = (CheckBox)sender;


            if (checkBox.Checked)
            {
                //Gọi ra 1 list các grade
                var grades = gradeService.GetListGrades(coursegrade.CourseGradeId, ClassId, rollNumber.Text).Select(x => new
                {
                    Grade = x.Score,
                }).ToList();

                //Thêm cột mới 

                if (!dataGridView1.Columns.Contains(coursegrade.GradeName))
                {
                    DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                    newColumn.HeaderText = coursegrade.GradeName;
                    newColumn.Name = coursegrade.GradeName;
                    dataGridView1.Columns.Add(newColumn);
                }



                var students = studentService.getStudentinClass(ClassId).Select(x => new
                {
                    StudentId = x.StudentId,
                    Name = x.Name,

                }).ToList();

                if (grades.Count > 0 && students.Count > 0)
                {
                    //Truyền dữ liệu vào cột với
                    for (int i = 0; i < students.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[coursegrade.GradeName].Value = grades[i].Grade;
                    }

                }
                else if (grades.Count == 0)
                {
                    gradeService.addNewGradeForcourseGrade(class1.ClassId, coursegrade.CourseGradeId);

                }

            }
            else
            {
                if (dataGridView1.Columns.Contains(coursegrade.GradeName))
                {
                    var column = dataGridView1.Columns[coursegrade.GradeName];
                    dataGridView1.Columns.Remove(column);
                }
            }
        }

        private void subject_Class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            dataGridView1.Rows.Clear();
            rollNumber.Text = string.Empty;

            UncheckAllCheckBoxes(this);
            LoadData();
        }
        /*  Nếu các check box dc checked thì sẽ unchecked*/
        private void UncheckAllCheckBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }

                if (c.HasChildren)
                {
                    UncheckAllCheckBoxes(c);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            string gradeName = dataGridView.Columns[e.ColumnIndex].Name;


            CourseGrade courseGrade = courseService.GetCourseGradeByName(class1.Course.CourseId, gradeName);
            List<Grade> grades = gradeService.GetListGrades(courseGrade.CourseGradeId, class1.ClassId, rollNumber.Text);
            Grade gradeChange = grades[e.RowIndex];

            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (grades.Count > 0)
                {
                    //Chỉ xử lí thay đổi ,chưa xử lí nhập mới
                    try
                    {
                        if (float.TryParse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out float a))
                        {
                            if (a >= 0 && a <= 10)
                            {
                                gradeService.updateGrade(gradeChange, a);
                            }
                            else
                            {
                                MessageBox.Show("Nhập số từ 0 - 10");
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
            else if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                gradeService.updateGrade(gradeChange, null);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string studentId = addnewStudent.Text;
            Student student = studentService.getStudentById(studentId);

            if (student != null)
            {
                bool isStudentinClass = studentService.IsStudentInClass(studentId, class1.ClassId);
                if (isStudentinClass)
                {
                    MessageBox.Show("Sinh viên đã ở trong lớp");
                }
                else
                {
                    // Thêm sinh mới vào 
                    studentService.addStudentInClass(studentId, class1.ClassId);
                    //Them vao muc điểm
                    List<CourseGrade> courseGrades = courseService.getListCourseGrade(class1.Course.CourseId);
                    if (courseGrades.Count > 0)
                    {
                        foreach (var coursegrade in courseGrades)
                        {
                            studentService.addGradeforStudent(studentId, class1.ClassId, coursegrade.CourseGradeId);
                        }
                        LoadData();

                    }


                }
            }
            else
            {
                MessageBox.Show("Roll number không tồn tại");
            }
        }

        private void rollNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string StudentID = rollNumber.Text;


            var student = studentService.getStudentById(StudentID);
            if (student != null)
            {

                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();

                dataGridView1.Rows.Clear();
                var selectedStudent = new List<object>
{
    new
    {
        StudentID = student.StudentId,
        Name = student.Name
    }
};
                dataGridView1.DataSource = selectedStudent;
                groupBox1.Controls.Clear();
                List<CourseGrade> courseGrades = courseService.getListCourseGrade(class1.Course.CourseId);
                if (courseGrades.Count > 0)
                {
                    foreach (var coursegrade in courseGrades)
                    {
                        List<Grade> grades = gradeService.GetListGrades(coursegrade.CourseGradeId, class1.ClassId, StudentID);


                        DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                        newColumn.HeaderText = coursegrade.GradeName;
                        newColumn.Name = coursegrade.GradeName;
                        dataGridView1.Columns.Add(newColumn);

                        dataGridView1.Rows[0].Cells[coursegrade.GradeName].Value = grades[0].Score;


                    }

                }




            }
            else
            {
                rollNumber.Controls.Clear();
                MessageBox.Show("Mã sinh viên không tồn tại");
            }





        }

        private void jhjhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCourse manageCourse = new ManageCourse();
            manageCourse.SetTearchID(tid);
            manageCourse.Show();
            this.Hide();
        }

        private void nameTeacher_Click(object sender, EventArgs e)
        {

        }

        private void addnewStudent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
