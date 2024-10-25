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

    public partial class Login : Form
    {
        ProjectPRN5Context _context = new ProjectPRN5Context();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                MessageBox.Show("Entrer email");
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Enter the password");
            }
            else
            {
                try
                {
                    Teacher teacher = _context.Teachers.FirstOrDefault(a => a.Password == password.Text && a.Email == email.Text);
                    if (teacher != null)
                    {


                        MainForm mainForm = new MainForm();
                        mainForm.SetTearchID(teacher.TeacherId);
                        mainForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Email or password valid");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
