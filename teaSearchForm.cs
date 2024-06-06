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
    public partial class teaSearchForm : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        public teaSearchForm()
        {
            InitializeComponent();
        }

        private void student_searchBtn_Click(object sender, EventArgs e)
        {
            string searchBySid=search_student_id.Text;
            if(string.IsNullOrEmpty(searchBySid) )
            {
                LoadData();
            }
            else
            {
                using (con)
                {
                    con.Open();
                    string sql = "select * from students where student_id=@sid";
                    using(SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        cmd.Parameters.AddWithValue("@sid", searchBySid);
                        using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt=new DataTable();
                            adapter.Fill(dt);
                            gridData.DataSource = dt;
                        }
                    }
                }
            }
        }
        public void LoadData()
        {
            addStudentData data= new addStudentData();
            gridData.DataSource = data.studentData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
