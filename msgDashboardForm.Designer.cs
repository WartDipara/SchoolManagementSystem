namespace SchoolManagementSystem
{
    partial class msgDashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schoolDBDataSet1 = new SchoolManagementSystem.SchoolDBDataSet();
            this.studentsTableAdapter1 = new SchoolManagementSystem.SchoolDBDataSetTableAdapters.studentsTableAdapter();
            this.input_msg = new System.Windows.Forms.TextBox();
            this.send_msg_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.send_msg_btn);
            this.panel1.Controls.Add(this.input_msg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(14, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 746);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "消息栏";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(882, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // schoolDBDataSet1
            // 
            this.schoolDBDataSet1.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter1
            // 
            this.studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // input_msg
            // 
            this.input_msg.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_msg.Location = new System.Drawing.Point(182, 526);
            this.input_msg.Multiline = true;
            this.input_msg.Name = "input_msg";
            this.input_msg.Size = new System.Drawing.Size(720, 192);
            this.input_msg.TabIndex = 3;
            // 
            // send_msg_btn
            // 
            this.send_msg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(65)))));
            this.send_msg_btn.FlatAppearance.BorderSize = 0;
            this.send_msg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.send_msg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(148)))), ((int)(((byte)(131)))));
            this.send_msg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_msg_btn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send_msg_btn.ForeColor = System.Drawing.Color.White;
            this.send_msg_btn.Location = new System.Drawing.Point(39, 526);
            this.send_msg_btn.Name = "send_msg_btn";
            this.send_msg_btn.Size = new System.Drawing.Size(109, 37);
            this.send_msg_btn.TabIndex = 4;
            this.send_msg_btn.Text = "发送";
            this.send_msg_btn.UseVisualStyleBackColor = false;
            this.send_msg_btn.Click += new System.EventHandler(this.send_msg_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "注意文明用语，打造良好校园环境";
            // 
            // teaDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "teaDashboardForm";
            this.Size = new System.Drawing.Size(1000, 800);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private SchoolDBDataSet schoolDBDataSet1;
        private SchoolDBDataSetTableAdapters.studentsTableAdapter studentsTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send_msg_btn;
        private System.Windows.Forms.TextBox input_msg;
    }
}
