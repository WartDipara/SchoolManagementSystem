using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    internal class addTeacherData
    {
        SqlConnection con =new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID{set; get;}
        public string teacher_ID { set; get; }
        public string teacher_Name { set; get; }
        public string teacher_Gender { set; get; }
        public string teacher_Addr { set; get; }
        public string teacher_Img { set; get; }
        public string teacher_Status { set; get; }
        public string date_insert { set; get; }
        public string date_update { set; get; }
        public string date_delete { set; get; }

        public List<addTeacherData> teacherData()
        {
            List<addTeacherData> listData = new List<addTeacherData>();
                try
                {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                    string sql = "select * from teachers where date_delete is NULL";

                    using(SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            addTeacherData data = new addTeacherData();
                            data.ID = (int)reader["id"];
                            data.teacher_ID = reader["teacher_id"].ToString();
                            data.teacher_Name = reader["teacher_name"].ToString() ;
                            data.teacher_Gender = reader["teacher_gender"].ToString();
                            data.teacher_Addr = reader["teacher_address"].ToString();
                            data.teacher_Img = reader["teacher_image"].ToString();
                            data.teacher_Status = reader["teacher_status"].ToString();
                            data.date_insert = reader["date_insert"].ToString();
                            data.date_update = reader["date_update"].ToString();
                            data.date_delete = reader["date_delete"].ToString();

                            listData.Add(data);
                        }
                        reader.Close();
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine("无法连接到数据库:" + ex);
                }
                finally
                {
                    con.Close();
                }
            
            return listData;
        }
    }
}
