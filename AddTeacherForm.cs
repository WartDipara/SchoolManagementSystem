using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddTeacherForm : UserControl
    {
        // 数据库连接字符串
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");

        public AddTeacherForm()
        {
            InitializeComponent();
            // 加载教师数据
            displayTeacherData();
        }

        // 显示教师数据
        public void displayTeacherData()
        {
            addTeacherData addTeacher = new addTeacherData();
            // 将教师数据绑定到 DataGridView
            teacher_gridData.DataSource = addTeacher.teacherData();
        }

        // 添加教师按钮点击事件处理方法
        private void teacher_addBtn_Click(object sender, EventArgs e)
        {
            // 检查是否所有输入都已填写
            if (teacher_id.Text == "" || teacher_name.Text == "" || teacher_gender.Text == null
                || teacher_status.Text == "" || teacher_img.Image == null || imagePath == null)
            {
                // 如果有任何字段为空，则显示错误消息
                MessageBox.Show("请输入完整登录信息。", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    // 检查教师编号是否已存在
                    string checkTeacherID = "select count(*) from teachers where teacher_id=@tID";
                    using (SqlCommand checkID = new SqlCommand(checkTeacherID, con))
                    {
                        checkID.Parameters.AddWithValue("@tid", teacher_id.Text.Trim());
                        int count = (int)checkID.ExecuteScalar();

                        if (count > 0)
                        {
                            // 如果教师编号已存在，则显示错误消息
                            MessageBox.Show("教师编号：" + teacher_id.Text.Trim() + " 已经存在数据库当中",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DateTime today = DateTime.Now;
                            // 插入教师信息到数据库
                            string insertData = "insert into teachers (teacher_id,teacher_name,teacher_gender,teacher_address,teacher_image,teacher_status,date_insert) " +
                                                "values(@tid,@tname,@tgender,@taddr,@timg,@ts,@data_insert)";

                            // 保存当地路径
                            string localPath = Path.Combine(@"C:\Users\29032\Desktop\三年级下学期\Windows编程\codeHere\FInal\SchoolManagementSystem\Teacher_field\", teacher_id.Text.Trim() + ".jpg");
                            string dirPath = Path.GetDirectoryName(localPath);
                            // 检查路径是否存在，如果不存在则创建
                            if (!Directory.Exists(dirPath))
                            {
                                Directory.CreateDirectory(dirPath);
                            }
                            // 将选择的教师图片复制到本地路径
                            File.Copy(imagePath, localPath, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, con))
                            {
                                // 添加参数并执行插入操作 comboBox要用Item来捕获，Value不行
                                cmd.Parameters.AddWithValue("@tid", teacher_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@tname", teacher_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@tgender", teacher_gender.SelectedItem.ToString().Trim());
                                cmd.Parameters.AddWithValue("@taddr", teacher_addr.Text.Trim());
                                cmd.Parameters.AddWithValue("@timg", localPath);
                                cmd.Parameters.AddWithValue("@ts", teacher_status.SelectedItem.ToString().Trim());
                                cmd.Parameters.AddWithValue("@data_insert", today.ToString());

                                cmd.ExecuteNonQuery();
                                // 显示成功消息
                                MessageBox.Show("新增教师信息成功!", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //刷新输入框
                                clearFields();
                                //重新刷新数据画面
                                displayTeacherData();
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
        //refresh
        public void clearFields()
        {
            teacher_id.Text = "";
            teacher_name.Text = "";
            teacher_gender.SelectedIndex = -1;
            teacher_addr.Text = "";
            teacher_status.SelectedIndex = -1;
            teacher_img.Image = null;
            imagePath = "";
        }

        // 存储选择的图片路径
        private string imagePath;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的图片路径并显示在 PictureBox 中
                imagePath = open.FileName;
                teacher_img.ImageLocation = imagePath;
            }
        }

        private void teacher_resetBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        //选中内容后直接输入到行内，方便查看用
        private void teacher_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = teacher_gridData.Rows[e.RowIndex];
                teacher_id.Text = row.Cells[1].Value.ToString();
                teacher_name.Text = row.Cells[2].Value.ToString();
                teacher_gender.Text = row.Cells[3].Value.ToString();
                teacher_addr.Text = row.Cells[4].Value.ToString();
                //teacher_img.Image = (Image)row.Cells[5].Value; 无法强制转换
                imagePath = row.Cells[5].Value.ToString();
                if (imagePath.Length > 0 && imagePath != null)
                {
                    teacher_img.Image = Image.FromFile(imagePath);
                }
                else
                {
                    teacher_img.Image = null;
                }
                teacher_status.Text = row.Cells[6].Value.ToString();
            }
        }

        //更新按钮
        private void teacher_updateBtn_Click(object sender, EventArgs e)
        {
            // 检查是否所有输入都已填写
            if (teacher_id.Text == "" || teacher_name.Text == "" || teacher_gender.SelectedItem.ToString() == ""
                || teacher_status.SelectedItem.ToString() == "" || teacher_img.Image == null || imagePath == null)
            {
                // 如果有任何字段为空，则显示错误消息
                MessageBox.Show("请输入完整登录信息。", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                try
                {
                    DialogResult check = MessageBox.Show("确定要更新编号为：" + teacher_id.Text.Trim() + " 的教师信息吗？(编号无法被修改)",
                        "Comfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        DateTime dateTime = DateTime.Now;
                        string updateData = "UPDATE teachers SET teacher_name = @tname, " +
                            "teacher_gender = @tgender, " +
                            "teacher_address = @taddr, " +
                            "teacher_status = @ts, " +
                            "date_update = @date_update " +
                            "WHERE teacher_id = @tid";

                        using (SqlCommand cmd = new SqlCommand(updateData, con))
                        {
                            SqlTransaction transaction = con.BeginTransaction();
                            cmd.Transaction = transaction;
                            cmd.Parameters.AddWithValue("@tname", teacher_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@tgender", teacher_gender.SelectedItem.ToString().Trim());
                            cmd.Parameters.AddWithValue("@taddr", teacher_addr.Text.Trim());
                            cmd.Parameters.AddWithValue("@ts", teacher_status.SelectedItem.ToString().Trim());
                            cmd.Parameters.AddWithValue("@date_update", dateTime);
                            cmd.Parameters.AddWithValue("@tid", teacher_id.Text.Trim());

                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            // 显示成功消息
                            MessageBox.Show("更新教师信息成功!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // 清除输入框
                            clearFields();
                            // 重新刷新数据画面
                            displayTeacherData();
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

        private void teacher_deleteBtn_Click(object sender, EventArgs e)
        {
            //并非真正的删除，只是隐藏掉显示，新增删除日期
            DialogResult check = MessageBox.Show("确定删除编号为: "
                         + teacher_id.Text + " 的教师吗？", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    DateTime dateTime   = DateTime.Now;

                    string deleteData = "UPDATE teachers SET date_delete = @date_delete " +
                                "WHERE teacher_id = @tid";
                    using(SqlCommand cmd=new SqlCommand(deleteData, con))
                    {
                        SqlTransaction transaction = con.BeginTransaction();
                        cmd.Transaction = transaction;
                        cmd.Parameters.AddWithValue("@date_delete", dateTime.ToString());
                        cmd.Parameters.AddWithValue("@tid", teacher_id.Text.Trim());

                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("成功执行删除操作。", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // 清除输入框
                        clearFields();
                        // 重新刷新数据画面
                        displayTeacherData();
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

        //分界线
    }
}
