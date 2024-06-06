using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddstudentForm : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        public AddstudentForm()
        {
            InitializeComponent();

            displayStudentData();
        }
        public void displayStudentData()
        {
            addStudentData data= new addStudentData();
            student_gridData.DataSource = data.studentData(); 
        }
        //添加成员
        private void student_addBtn_Click(object sender, EventArgs e)
        {
            // 检查是否所有输入都已填写
            if (student_id.Text == "" || student_name.Text == "" || student_gender.SelectedIndex == -1
                || student_status.Text == "" || student_img.Image == null || imagePath == null|| student_dep.SelectedIndex==-1)
            {
                // 如果有任何字段为空，则显示错误消息
                MessageBox.Show("请输入完整登录信息。", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    // 检查是否已存在
                    string checkStudentID = "select count(*) from students where student_id=@sID";
                    using (SqlCommand checkID = new SqlCommand(checkStudentID, con))
                    {
                        checkID.Parameters.AddWithValue("@sid", student_id.Text.Trim());
                        int count = (int)checkID.ExecuteScalar();

                        if (count > 0)
                        {
                            // 如果学生已存在，则显示错误消息
                            MessageBox.Show("学号：" + student_id.Text.Trim() + " 已经存在数据库当中",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DateTime today = DateTime.Now;
       
                            string insertData = "insert into students (student_id,student_name,student_gender,student_grade,student_address,student_department,student_image,student_status,date_insert) " +
                                                "values(@sid,@sname,@sgender,@sgrade,@saddr,@sdep,@simg,@ss,@data_insert)";

                            // 保存当地路径
                            string localPath = Path.Combine(@"C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\Student_field\", student_id.Text.Trim() + ".jpg");
                            string dirPath = Path.GetDirectoryName(localPath);
                            // 检查路径是否存在，如果不存在则创建
                            if (!Directory.Exists(dirPath))
                            {
                                Directory.CreateDirectory(dirPath);
                            }
                            File.Copy(imagePath, localPath, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, con))
                            {
                                SqlTransaction transaction = con.BeginTransaction();
                                cmd.Transaction = transaction;
                                // 添加参数并执行插入操作 comboBox要用Item来捕获，Value不行
                                cmd.Parameters.AddWithValue("@sid", student_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@sname", student_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@sgender", student_gender.SelectedItem.ToString().Trim());
                                cmd.Parameters.AddWithValue("@sgrade", student_grade.SelectedItem.ToString().Trim());
                                cmd.Parameters.AddWithValue("@saddr", student_addr.Text.Trim());
                                cmd.Parameters.AddWithValue("@sdep", student_dep.SelectedItem.ToString().Trim());
                                cmd.Parameters.AddWithValue("@simg", localPath);
                                cmd.Parameters.AddWithValue("@ss", student_status.SelectedItem.ToString().Trim());
                                cmd.Parameters.AddWithValue("@data_insert", today.ToString());

                                cmd.ExecuteNonQuery();
                                transaction.Commit();
                                // 显示成功消息
                                MessageBox.Show("新增学生信息成功!", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //刷新输入框
                                clearFields();
                                //重新刷新数据画面
                                displayStudentData();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 捕获并显示数据库连接失败的异常消息
                    MessageBox.Show("数据库连接失败：" + ex.Message, "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private string imagePath;
        public void clearFields()
        {
            student_id.Text = "";
            student_name.Text = "";
            student_gender.SelectedIndex = -1;
            student_grade.SelectedIndex = -1;
            student_addr.Text = "";
            student_dep.SelectedIndex = -1;
            student_status.SelectedIndex = -1;
            student_img.Image= null;
            imagePath = "";
        }
        private void student_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = student_gridData.Rows[e.RowIndex];
                student_id.Text = row.Cells[1].Value.ToString();
                student_name.Text = row.Cells[2].Value.ToString();
                student_gender.Text = row.Cells[3].Value.ToString();
                student_grade.Text = row.Cells[4].Value.ToString();
                student_addr.Text = row.Cells[5].Value.ToString();
                imagePath = row.Cells[6].Value.ToString();
                if (imagePath != null && imagePath.Length > 0)
                {
                   student_img.Image = Image.FromFile(imagePath);

                }
                else
                {
                    student_img = null;
                }
                student_dep.Text = row.Cells[7].Value.ToString();
                
                student_status.Text = row.Cells[8].Value.ToString();
            }
        }

        private void student_importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的图片路径并显示在 PictureBox 中
                imagePath = open.FileName;
                student_img.ImageLocation = imagePath;
            }
        }

        private void student_resetBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void student_updateBtn_Click(object sender, EventArgs e)
        {
            // 检查是否所有输入都已填写
            if (student_id.Text == "" || student_name.Text == "" || student_gender.SelectedIndex == -1
                || student_status.SelectedIndex == -1 || student_img.Image == null || student_dep.SelectedIndex==-1 || student_grade.SelectedIndex==-1)
            {
                // 如果有任何字段为空，则显示错误消息
                MessageBox.Show("请输入完整信息。", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                try
                {
                    DialogResult check = MessageBox.Show("确定要更新编号为：" + student_id.Text.Trim() + " 的学生信息吗？",
                        "Comfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        DateTime dateTime = DateTime.Now;
                        string updateData = "UPDATE students SET student_name = @sname, " +
                            "student_gender = @sgender, " +
                            "student_grade = @sgrade, "+
                            "student_address = @saddr, " +
                            "student_department = @sdep, "+
                            "student_status = @ss, " +
                            "date_update = @date_update " +
                            "WHERE student_id = @sid";

                        using (SqlCommand cmd = new SqlCommand(updateData, con))
                        {
                            SqlTransaction transaction = con.BeginTransaction();
                            cmd.Transaction = transaction;
                            cmd.Parameters.AddWithValue("@sname", student_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@sgender", student_gender.SelectedItem.ToString().Trim());
                            cmd.Parameters.AddWithValue("@sgrade",student_grade.SelectedItem.ToString().Trim());
                            cmd.Parameters.AddWithValue("@saddr", student_addr.Text.Trim());
                            cmd.Parameters.AddWithValue("@sdep",student_dep.Text.Trim());
                            cmd.Parameters.AddWithValue("@ss", student_status.SelectedItem.ToString().Trim());
                            cmd.Parameters.AddWithValue("@date_update", dateTime);
                            cmd.Parameters.AddWithValue("@sid", student_id.Text.Trim());

                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            // 显示成功消息
                            MessageBox.Show("更新学生信息成功!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // 清除输入框
                            clearFields();
                            // 重新刷新数据画面
                            displayStudentData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("已取消操作", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
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

        private void student_deleteBtn_Click(object sender, EventArgs e)
        {
            //并非真正的删除，只是隐藏掉显示，新增删除日期
            DialogResult check = MessageBox.Show("确定删除学号为: "
                         + student_id.Text + " 的学生吗？", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    DateTime dateTime = DateTime.Now;

                    string deleteData = "UPDATE students SET date_delete = @date_delete " +
                                "WHERE student_id = @sid";
                    using (SqlCommand cmd = new SqlCommand(deleteData, con))
                    {
                        SqlTransaction transaction = con.BeginTransaction();
                        cmd.Transaction = transaction;
                        cmd.Parameters.AddWithValue("@date_delete", dateTime.ToString());
                        cmd.Parameters.AddWithValue("@sid", student_id.Text.Trim());

                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("成功执行删除操作。", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // 清除输入框
                        clearFields();
                        // 重新刷新数据画面
                        displayStudentData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接数据库失败: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { con.Close(); }
            }
        }
        /////////
    }
}
