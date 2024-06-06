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
    public partial class DashboardForm : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        public DashboardForm()
        {
            InitializeComponent();
            displayALLstu();
            displayALLtea();
        }
        public void displayALLtea()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    int temp = 0;
                    con.Open();
                    string sql = "select count(id) from teachers where teacher_status = 'active' ";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            temp = Convert.ToInt32(reader[0]);
                            label3.Text = temp.ToString();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库连接失败：" + ex.Message, "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void displayALLstu()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    int temp = 0;
                    con.Open();
                    string sql = "select count(id) from students where student_status = 'active' ";
                    
                    using(SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            temp = Convert.ToInt32(reader[0]);
                            label2.Text=temp.ToString();
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库连接失败：" + ex.Message, "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
