namespace SchoolManagementSystem
{
    partial class AddstudentForm
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.student_img = new System.Windows.Forms.PictureBox();
            this.student_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.student_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.student_grade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.student_deleteBtn = new System.Windows.Forms.Button();
            this.student_resetBtn = new System.Windows.Forms.Button();
            this.student_updateBtn = new System.Windows.Forms.Button();
            this.student_addBtn = new System.Windows.Forms.Button();
            this.student_importBtn = new System.Windows.Forms.Button();
            this.student_dep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.student_addr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.student_gridData = new System.Windows.Forms.DataGridView();
            this.schoolDBDataSet = new SchoolManagementSystem.SchoolDBDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new SchoolManagementSystem.SchoolDBDataSetTableAdapters.studentsTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_img)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.student_img);
            this.panel3.Location = new System.Drawing.Point(807, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 131);
            this.panel3.TabIndex = 24;
            // 
            // student_img
            // 
            this.student_img.Location = new System.Drawing.Point(0, 2);
            this.student_img.Name = "student_img";
            this.student_img.Size = new System.Drawing.Size(117, 129);
            this.student_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.student_img.TabIndex = 29;
            this.student_img.TabStop = false;
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(129, 91);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(141, 21);
            this.student_name.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(293, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "地址:";
            // 
            // student_gender
            // 
            this.student_gender.FormattingEnabled = true;
            this.student_gender.Items.AddRange(new object[] {
            "男",
            "女",
            "其他"});
            this.student_gender.Location = new System.Drawing.Point(129, 149);
            this.student_gender.Name = "student_gender";
            this.student_gender.Size = new System.Drawing.Size(141, 20);
            this.student_gender.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "性别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "学生姓名:";
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(128, 39);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(142, 21);
            this.student_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "学号:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.student_status);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.student_grade);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.student_deleteBtn);
            this.panel2.Controls.Add(this.student_resetBtn);
            this.panel2.Controls.Add(this.student_updateBtn);
            this.panel2.Controls.Add(this.student_addBtn);
            this.panel2.Controls.Add(this.student_importBtn);
            this.panel2.Controls.Add(this.student_dep);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.student_addr);
            this.panel2.Controls.Add(this.student_name);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.student_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.student_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 368);
            this.panel2.TabIndex = 11;
            // 
            // student_status
            // 
            this.student_status.FormattingEnabled = true;
            this.student_status.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.student_status.Location = new System.Drawing.Point(668, 96);
            this.student_status.Name = "student_status";
            this.student_status.Size = new System.Drawing.Size(120, 20);
            this.student_status.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(581, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "状态:";
            // 
            // student_grade
            // 
            this.student_grade.FormattingEnabled = true;
            this.student_grade.Items.AddRange(new object[] {
            "ba",
            "master",
            "phd"});
            this.student_grade.Location = new System.Drawing.Point(359, 153);
            this.student_grade.Name = "student_grade";
            this.student_grade.Size = new System.Drawing.Size(183, 20);
            this.student_grade.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(293, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "学位:";
            // 
            // student_deleteBtn
            // 
            this.student_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.student_deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.student_deleteBtn.FlatAppearance.BorderSize = 2;
            this.student_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(184)))));
            this.student_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.student_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.student_deleteBtn.Location = new System.Drawing.Point(668, 266);
            this.student_deleteBtn.Name = "student_deleteBtn";
            this.student_deleteBtn.Size = new System.Drawing.Size(121, 42);
            this.student_deleteBtn.TabIndex = 22;
            this.student_deleteBtn.Text = "删除";
            this.student_deleteBtn.UseVisualStyleBackColor = false;
            this.student_deleteBtn.Click += new System.EventHandler(this.student_deleteBtn_Click);
            // 
            // student_resetBtn
            // 
            this.student_resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.student_resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.student_resetBtn.FlatAppearance.BorderSize = 2;
            this.student_resetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(184)))));
            this.student_resetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.student_resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_resetBtn.ForeColor = System.Drawing.Color.White;
            this.student_resetBtn.Location = new System.Drawing.Point(506, 266);
            this.student_resetBtn.Name = "student_resetBtn";
            this.student_resetBtn.Size = new System.Drawing.Size(121, 42);
            this.student_resetBtn.TabIndex = 21;
            this.student_resetBtn.Text = "重设";
            this.student_resetBtn.UseVisualStyleBackColor = false;
            this.student_resetBtn.Click += new System.EventHandler(this.student_resetBtn_Click);
            // 
            // student_updateBtn
            // 
            this.student_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.student_updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.student_updateBtn.FlatAppearance.BorderSize = 2;
            this.student_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(184)))));
            this.student_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.student_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_updateBtn.ForeColor = System.Drawing.Color.White;
            this.student_updateBtn.Location = new System.Drawing.Point(338, 266);
            this.student_updateBtn.Name = "student_updateBtn";
            this.student_updateBtn.Size = new System.Drawing.Size(121, 42);
            this.student_updateBtn.TabIndex = 20;
            this.student_updateBtn.Text = "更新";
            this.student_updateBtn.UseVisualStyleBackColor = false;
            this.student_updateBtn.Click += new System.EventHandler(this.student_updateBtn_Click);
            // 
            // student_addBtn
            // 
            this.student_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.student_addBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.student_addBtn.FlatAppearance.BorderSize = 2;
            this.student_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(184)))));
            this.student_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.student_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_addBtn.ForeColor = System.Drawing.Color.White;
            this.student_addBtn.Location = new System.Drawing.Point(170, 266);
            this.student_addBtn.Name = "student_addBtn";
            this.student_addBtn.Size = new System.Drawing.Size(121, 42);
            this.student_addBtn.TabIndex = 19;
            this.student_addBtn.Text = "新增";
            this.student_addBtn.UseVisualStyleBackColor = false;
            this.student_addBtn.Click += new System.EventHandler(this.student_addBtn_Click);
            // 
            // student_importBtn
            // 
            this.student_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.student_importBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.student_importBtn.FlatAppearance.BorderSize = 2;
            this.student_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_importBtn.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_importBtn.ForeColor = System.Drawing.Color.White;
            this.student_importBtn.Location = new System.Drawing.Point(807, 162);
            this.student_importBtn.Name = "student_importBtn";
            this.student_importBtn.Size = new System.Drawing.Size(117, 40);
            this.student_importBtn.TabIndex = 8;
            this.student_importBtn.Text = "上传头像";
            this.student_importBtn.UseVisualStyleBackColor = false;
            this.student_importBtn.Click += new System.EventHandler(this.student_importBtn_Click);
            // 
            // student_dep
            // 
            this.student_dep.FormattingEnabled = true;
            this.student_dep.Items.AddRange(new object[] {
            "信息科学与工程学院",
            "医学院",
            "新闻传播学院",
            "体育学院",
            "艺术学院",
            "人工智能学院",
            "理学院",
            "人文学院"});
            this.student_dep.Location = new System.Drawing.Point(668, 45);
            this.student_dep.Name = "student_dep";
            this.student_dep.Size = new System.Drawing.Size(120, 20);
            this.student_dep.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(581, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "院系:";
            // 
            // student_addr
            // 
            this.student_addr.Location = new System.Drawing.Point(359, 39);
            this.student_addr.Multiline = true;
            this.student_addr.Name = "student_addr";
            this.student_addr.Size = new System.Drawing.Size(183, 83);
            this.student_addr.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "学生数据";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.student_gridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 353);
            this.panel1.TabIndex = 10;
            // 
            // student_gridData
            // 
            this.student_gridData.AllowUserToAddRows = false;
            this.student_gridData.AllowUserToDeleteRows = false;
            this.student_gridData.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.NullValue = "Empty";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.student_gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.student_gridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(184)))));
            this.student_gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.student_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.student_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_gridData.EnableHeadersVisualStyles = false;
            this.student_gridData.Location = new System.Drawing.Point(27, 52);
            this.student_gridData.Name = "student_gridData";
            this.student_gridData.ReadOnly = true;
            this.student_gridData.RowHeadersVisible = false;
            this.student_gridData.RowTemplate.Height = 23;
            this.student_gridData.Size = new System.Drawing.Size(912, 259);
            this.student_gridData.TabIndex = 4;
            this.student_gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_gridData_CellClick);
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // AddstudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddstudentForm";
            this.Size = new System.Drawing.Size(1000, 800);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.student_img)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox student_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox student_grade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button student_deleteBtn;
        private System.Windows.Forms.Button student_resetBtn;
        private System.Windows.Forms.Button student_updateBtn;
        private System.Windows.Forms.Button student_addBtn;
        private System.Windows.Forms.Button student_importBtn;
        private System.Windows.Forms.ComboBox student_dep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox student_addr;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox student_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox student_img;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private SchoolDBDataSet schoolDBDataSet;
        private SchoolDBDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridView student_gridData;
    }
}
