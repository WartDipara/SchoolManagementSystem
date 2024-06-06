using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace SchoolManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("请输入完整登录信息。", "Error Message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();

                    string selectData = "SELECT * FROM users WHERE username =@username "
                        + "AND password =@password";

                    using (SqlCommand cmd = new SqlCommand(selectData,con))
                    {
                        cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("登陆成功!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm mainbox = new MainForm();
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
                catch(Exception ex)
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

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
        }

        private void login_switch_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLoginForm studentLoginForm = new StudentLoginForm();
            studentLoginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherLoginForm teacherLoginForm = new teacherLoginForm();
            teacherLoginForm.Show();
            this.Hide();
        }
    }
}
