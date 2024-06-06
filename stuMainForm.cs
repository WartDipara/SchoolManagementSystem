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
    public partial class stuMainForm : Form
    {
        public stuMainForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            msgDashboardForm1.Visible = true;
            schoolintroForm1.Visible = false;
        }

        private void teaBtn_Click(object sender, EventArgs e)
        {
            schoolintroForm1.Visible = true;
            msgDashboardForm1.Visible = false ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("你确定要登出吗？", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                StudentLoginForm login = new StudentLoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}
