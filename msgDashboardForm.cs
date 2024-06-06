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
    public partial class msgDashboardForm : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        public msgDashboardForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            addMsg data = new addMsg();
            dataGridView1.DataSource = data.msgData();
        }

        private void send_msg_btn_Click(object sender, EventArgs e)
        {
            string msgText=input_msg.Text.Trim();
            if(string.IsNullOrEmpty(msgText))
            {
                MessageBox.Show("请输入消息内容。");
                return;
            }
            //捕获当前用户内容
            string username = userInfo.logined_UserName;

            string sql = "insert into messagebox (username,msg,date_upload) " +
                "values(@username,@msg,@date_upload)";

            using (con)
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@msg", input_msg.Text);
                    cmd.Parameters.AddWithValue("@date_upload", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("发送成功。","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //清空输入框
            input_msg.Text = string.Empty;

            LoadData();
        }
    }
}
