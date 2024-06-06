namespace SchoolManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.teaBtn = new System.Windows.Forms.Button();
            this.stuBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardForm2 = new SchoolManagementSystem.DashboardForm();
            this.addTeacherForm2 = new SchoolManagementSystem.AddTeacherForm();
            this.addstudentForm2 = new SchoolManagementSystem.AddstudentForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 37);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1257, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(18, 18);
            this.exit.TabIndex = 11;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "校园管理系统界面";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.teaBtn);
            this.panel2.Controls.Add(this.stuBtn);
            this.panel2.Controls.Add(this.dashboardBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 803);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(213)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = global::SchoolManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_35px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 756);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "登出";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // teaBtn
            // 
            this.teaBtn.BackColor = System.Drawing.Color.Transparent;
            this.teaBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.teaBtn.FlatAppearance.BorderSize = 2;
            this.teaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(184)))));
            this.teaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.teaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teaBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teaBtn.ForeColor = System.Drawing.Color.White;
            this.teaBtn.Image = ((System.Drawing.Image)(resources.GetObject("teaBtn.Image")));
            this.teaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teaBtn.Location = new System.Drawing.Point(27, 465);
            this.teaBtn.Name = "teaBtn";
            this.teaBtn.Size = new System.Drawing.Size(230, 63);
            this.teaBtn.TabIndex = 4;
            this.teaBtn.Text = "添加老师";
            this.teaBtn.UseVisualStyleBackColor = false;
            this.teaBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // stuBtn
            // 
            this.stuBtn.BackColor = System.Drawing.Color.Transparent;
            this.stuBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stuBtn.FlatAppearance.BorderSize = 2;
            this.stuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(184)))));
            this.stuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.stuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stuBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stuBtn.ForeColor = System.Drawing.Color.White;
            this.stuBtn.Image = ((System.Drawing.Image)(resources.GetObject("stuBtn.Image")));
            this.stuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stuBtn.Location = new System.Drawing.Point(27, 374);
            this.stuBtn.Name = "stuBtn";
            this.stuBtn.Size = new System.Drawing.Size(230, 63);
            this.stuBtn.TabIndex = 3;
            this.stuBtn.Text = "添加学生";
            this.stuBtn.UseVisualStyleBackColor = false;
            this.stuBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dashboardBtn.FlatAppearance.BorderSize = 2;
            this.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(184)))));
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(26, 291);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(230, 63);
            this.dashboardBtn.TabIndex = 2;
            this.dashboardBtn.Text = "在校状态";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎您，管理员!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboardForm2);
            this.panel3.Controls.Add(this.addTeacherForm2);
            this.panel3.Controls.Add(this.addstudentForm2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(284, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 803);
            this.panel3.TabIndex = 2;
            // 
            // dashboardForm2
            // 
            this.dashboardForm2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardForm2.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm2.Name = "dashboardForm2";
            this.dashboardForm2.Size = new System.Drawing.Size(1004, 803);
            this.dashboardForm2.TabIndex = 2;
            // 
            // addTeacherForm2
            // 
            this.addTeacherForm2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTeacherForm2.Location = new System.Drawing.Point(0, 0);
            this.addTeacherForm2.Name = "addTeacherForm2";
            this.addTeacherForm2.Size = new System.Drawing.Size(1004, 803);
            this.addTeacherForm2.TabIndex = 1;
            // 
            // addstudentForm2
            // 
            this.addstudentForm2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addstudentForm2.Location = new System.Drawing.Point(0, 0);
            this.addstudentForm2.Name = "addstudentForm2";
            this.addstudentForm2.Size = new System.Drawing.Size(1004, 803);
            this.addstudentForm2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 840);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button teaBtn;
        private System.Windows.Forms.Button stuBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel3;
        private AddTeacherForm addTeacherForm1;
        private AddstudentForm addstudentForm1;
        private DashboardForm dashboardForm1;
        private AddstudentForm addstudentForm2;
        private AddTeacherForm addTeacherForm2;
        private DashboardForm dashboardForm2;
    }
}