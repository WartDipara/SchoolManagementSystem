namespace SchoolManagementSystem
{
    partial class teacherLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherLoginForm));
            this.tea_login_btn = new System.Windows.Forms.Button();
            this.tea_login_showPassword = new System.Windows.Forms.CheckBox();
            this.tea_login_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tea_login_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tea_login_switch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tea_login_btn
            // 
            this.tea_login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.tea_login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tea_login_btn.FlatAppearance.BorderSize = 0;
            this.tea_login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.tea_login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(78)))), ((int)(((byte)(100)))));
            this.tea_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tea_login_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tea_login_btn.ForeColor = System.Drawing.Color.White;
            this.tea_login_btn.Location = new System.Drawing.Point(494, 390);
            this.tea_login_btn.Name = "tea_login_btn";
            this.tea_login_btn.Size = new System.Drawing.Size(186, 49);
            this.tea_login_btn.TabIndex = 35;
            this.tea_login_btn.Text = "登录";
            this.tea_login_btn.UseVisualStyleBackColor = false;
            this.tea_login_btn.Click += new System.EventHandler(this.tea_login_btn_Click);
            // 
            // tea_login_showPassword
            // 
            this.tea_login_showPassword.AutoSize = true;
            this.tea_login_showPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tea_login_showPassword.Location = new System.Drawing.Point(669, 331);
            this.tea_login_showPassword.Name = "tea_login_showPassword";
            this.tea_login_showPassword.Size = new System.Drawing.Size(74, 18);
            this.tea_login_showPassword.TabIndex = 34;
            this.tea_login_showPassword.Text = "显示密码";
            this.tea_login_showPassword.UseVisualStyleBackColor = true;
            this.tea_login_showPassword.CheckedChanged += new System.EventHandler(this.tea_login_showPassword_CheckedChanged);
            // 
            // tea_login_password
            // 
            this.tea_login_password.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.tea_login_password.Location = new System.Drawing.Point(435, 286);
            this.tea_login_password.Name = "tea_login_password";
            this.tea_login_password.PasswordChar = '*';
            this.tea_login_password.Size = new System.Drawing.Size(308, 40);
            this.tea_login_password.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "密码:";
            // 
            // tea_login_username
            // 
            this.tea_login_username.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.tea_login_username.Location = new System.Drawing.Point(435, 202);
            this.tea_login_username.Name = "tea_login_username";
            this.tea_login_username.Size = new System.Drawing.Size(308, 40);
            this.tea_login_username.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 50);
            this.label2.TabIndex = 29;
            this.label2.Text = "教师登录";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tea_login_switch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 556);
            this.panel1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(78)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(11, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 41;
            this.button1.Text = "切换到管理员版";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tea_login_switch
            // 
            this.tea_login_switch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.tea_login_switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tea_login_switch.FlatAppearance.BorderSize = 0;
            this.tea_login_switch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(83)))), ((int)(((byte)(104)))));
            this.tea_login_switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(78)))), ((int)(((byte)(100)))));
            this.tea_login_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tea_login_switch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tea_login_switch.ForeColor = System.Drawing.Color.White;
            this.tea_login_switch.Location = new System.Drawing.Point(113, 463);
            this.tea_login_switch.Name = "tea_login_switch";
            this.tea_login_switch.Size = new System.Drawing.Size(186, 49);
            this.tea_login_switch.TabIndex = 18;
            this.tea_login_switch.Text = "还没账号？立即注册";
            this.tea_login_switch.UseVisualStyleBackColor = false;
            this.tea_login_switch.Click += new System.EventHandler(this.tea_login_switch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.label6.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(80, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "暨南大学校园管理系统";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(760, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(18, 18);
            this.exit.TabIndex = 28;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // teacherLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 556);
            this.Controls.Add(this.tea_login_btn);
            this.Controls.Add(this.tea_login_showPassword);
            this.Controls.Add(this.tea_login_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tea_login_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teacherLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacherLoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tea_login_btn;
        private System.Windows.Forms.CheckBox tea_login_showPassword;
        private System.Windows.Forms.TextBox tea_login_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tea_login_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tea_login_switch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label exit;
    }
}