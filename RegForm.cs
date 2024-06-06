using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class RegForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        public RegForm()
        {
            InitializeComponent();
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            reg_password.PasswordChar = reg_showPassword.Checked ? '\0' : '*';
            reg_confirmPw.PasswordChar = reg_showPassword.Checked ? '\0' : '*';
        }

        private void reg_switch_Click(object sender, EventArgs e)
        {
            LoginForm login=new LoginForm();
            login.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (reg_username.Text == "" || reg_password.Text == "" || reg_confirmPw.Text == "")
            {
                MessageBox.Show("请输入完整登录信息。", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (reg_password.Text != reg_confirmPw.Text)
            {
                MessageBox.Show("两次输入的密码不一致", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlTransaction transaction = null;

            try
            {
                con.Open();
                transaction = con.BeginTransaction();

                // 检查用户名是否存在
                string checkID = "SELECT COUNT(*) FROM users WHERE username = @uid";

                using (SqlCommand cmd = new SqlCommand(checkID, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@uid", reg_username.Text.Trim());
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("用户名已存在", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // 插入新用户
                string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@username", reg_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", reg_password.Text.Trim());
                    cmd.ExecuteNonQuery();

                }

                transaction.Commit();
                MessageBox.Show("注册成功", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm login=new LoginForm();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("注册失败：" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stuRegForm stuRegForm = new stuRegForm();
            stuRegForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teaRegForm teaRegForm = new teaRegForm();
            teaRegForm.Show();
            this.Hide();
        }
    }
}
