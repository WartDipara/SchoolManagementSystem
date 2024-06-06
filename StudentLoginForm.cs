using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class StudentLoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        public StudentLoginForm()
        {
            InitializeComponent();
        }

        private void stu_login_btn_Click(object sender, EventArgs e)
        {
            if (stu_login_username.Text == "" || stu_login_password.Text == "")
            {
                MessageBox.Show("请输入完整登录信息。", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();

                    string selectData = "SELECT * FROM stu_users WHERE student_ac =@username "
                        + "AND student_pw =@password";

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@username", stu_login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", stu_login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("登陆成功!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //记录下当前id，后续用
                            userInfo.logined_UserName = stu_login_username.Text.Trim();

                            stuMainForm mainbox = new stuMainForm();
                            mainbox.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("登陆失败\n请检查账号或密码是否正确。", "Error Message",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex,
                   "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void stu_login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            stu_login_password.PasswordChar = stu_login_showPassword.Checked ? '\0' : '*';
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stu_login_switch_Click(object sender, EventArgs e)
        {
            stuRegForm stuRegForm = new stuRegForm();
            stuRegForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }
    }
}
