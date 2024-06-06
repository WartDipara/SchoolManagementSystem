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
    public partial class teacherLoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        public teacherLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void tea_login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            tea_login_password.PasswordChar = tea_login_showPassword.Checked ? '\0' : '*';
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tea_login_btn_Click(object sender, EventArgs e)
        {
            if (tea_login_username.Text == "" || tea_login_password.Text == "")
            {
                MessageBox.Show("请输入完整登录信息。", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();

                    string selectData = "SELECT * FROM tea_users WHERE teacher_ac =@username "
                        + "AND teacher_pw =@password";

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@username", tea_login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", tea_login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("登陆成功!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //记录下当前id，后续用
                            userInfo.logined_UserName = tea_login_username.Text.Trim();

                            teaMainForm mainbox = new teaMainForm();
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

        private void tea_login_switch_Click(object sender, EventArgs e)
        {
            teaRegForm teaRegForm = new teaRegForm();
            teaRegForm.Show();
            this.Hide();
        }
    }
}
