using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    internal class addStudentData
    {
        //数据库链接
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        //获取元素
        public int ID { set; get; }
        public string student_ID { set; get; }
        public string student_Name { set; get; }
        public string student_Gender { set; get; }
        public string student_Grade { set; get; }
        public string student_Addr { set; get; }
        public string student_Img { set; get; }
        public string student_dep { set; get; }
        public string student_Status { set; get; }
        public string date_insert { set; get; }
        public string date_update { set; get; }
        public string date_delete { set; get; }

        //用于展示
        public List<addStudentData> studentData()
        {
            List<addStudentData> listData = new List<addStudentData>();
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    //sql语句
                    string sql = "select * from students where date_delete is NULL";
                    //命令编辑
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            addStudentData data = new addStudentData();
                            //从SqlDataReader类获取数据库中的内容
                            data.ID = (int)reader["id"];
                            data.student_ID = reader["student_id"].ToString();
                            data.student_Name = reader["student_name"].ToString();
                            data.student_Gender = reader["student_gender"].ToString();
                            data.student_Grade = reader["student_grade"].ToString();
                            data.student_Addr = reader["student_address"].ToString();
                            data.student_Img = reader["student_image"].ToString();
                            data.student_dep = reader["student_department"].ToString() ;
                            data.student_Status = reader["student_status"].ToString();
                            data.date_insert = reader["date_insert"].ToString();
                            //把所有的数据都加入进列表,用于其他类调用时访问数据库内容
                            listData.Add(data);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("无法连接到数据库:" + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return listData;
        }

        public List<addStudentData> dashboardStudentData()
        {
            List<addStudentData> listData = new List<addStudentData>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    DateTime today = DateTime.Today;
                    string sql = "select * from students where date_insert = @dateInsert " +
                    "and date_delete is NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@dateInsert", today.ToString());
                        SqlDataReader reader = cmd.ExecuteReader();
                        //获取数据库内容
                        while (reader.Read())
                        {
                            addStudentData  date = new addStudentData();
                            date.ID = (int)reader["id"];
                            date.student_ID = reader["student_id"].ToString();
                            date.student_Name = reader["student_name"].ToString();
                            date.student_Gender = reader["student_gender"].ToString();
                            date.student_Addr = reader["student_address"].ToString();
                            date.student_Grade = reader["student_grade"].ToString();
                            date.student_dep = reader["student_department"].ToString();
                            date.student_Img = reader["student_image"].ToString();
                            date.student_Status = reader["student_status"].ToString();
                            date.date_insert = reader["date_insert"].ToString();

                            listData.Add(date);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return listData;
        }
    }
}
