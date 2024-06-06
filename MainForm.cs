using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("你确定要登出吗？", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check==DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardForm2.Visible = true;
            addstudentForm2.Visible = false;
            addTeacherForm2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboardForm2.Visible = false;
            addstudentForm2.Visible = true;
            addTeacherForm2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboardForm2.Visible = false;
            addstudentForm2.Visible = false;
            addTeacherForm2.Visible = true;
        }


    }
}
