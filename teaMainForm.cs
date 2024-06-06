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
    public partial class teaMainForm : Form
    {
        public teaMainForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("你确定要登出吗？", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                teacherLoginForm login = new teacherLoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            teaDashboardForm1.Visible = true;
            teaSearchForm1.Visible = false;
        }

        private void stuBtn_Click(object sender, EventArgs e)
        {
            teaDashboardForm1.Visible = false;
            teaSearchForm1.Visible = true;
        }
    }
}
