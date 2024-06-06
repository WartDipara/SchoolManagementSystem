using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    internal class addMsg
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        public string username { set; get; }
        public string msg { set; get; }
        public string date_upload { set; get; }

        public List<addMsg> msgData()
        {
            List<addMsg> listData = new List<addMsg>();
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    //sql语句
                    string sql = "select * from messagebox order by date_upload desc";
                    //命令编辑
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            addMsg data = new addMsg();
                            //从SqlDataReader类获取数据库中的内容
                            data.username = reader["username"].ToString();
                            data.msg = reader["msg"].ToString();
                            data.date_upload = Convert.ToDateTime(reader["date_upload"]).ToString();

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

    }
}
