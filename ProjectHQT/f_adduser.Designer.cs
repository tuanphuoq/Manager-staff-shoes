namespace ProjectHQT
{
    partial class f_adduser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.cbox_level = new System.Windows.Forms.ComboBox();
            this.txt_add_password = new System.Windows.Forms.TextBox();
            this.txt_add_username = new System.Windows.Forms.TextBox();
            this.txt_add_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_add_user);
            this.groupBox1.Controls.Add(this.cbox_level);
            this.groupBox1.Controls.Add(this.txt_add_password);
            this.groupBox1.Controls.Add(this.txt_add_username);
            this.groupBox1.Controls.Add(this.txt_add_login);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TẠO MỚI NGƯỜI DÙNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(37, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "VUI LÒNG NHẬP ĐẦY ĐỦ CÁC THÔNG TIN NGƯỜI DÙNG";
            // 
            // btn_add_user
            // 
            this.btn_add_user.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_add_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_user.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add_user.Location = new System.Drawing.Point(40, 176);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(296, 31);
            this.btn_add_user.TabIndex = 8;
            this.btn_add_user.Text = "XÁC NHẬN TẠO MỚI NHÂN SỰ";
            this.btn_add_user.UseVisualStyleBackColor = false;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // cbox_level
            // 
            this.cbox_level.FormattingEnabled = true;
            this.cbox_level.Items.AddRange(new object[] {
            "ADMIN",
            "QUẢN LÝ",
            "NHÂN VIÊN"});
            this.cbox_level.Location = new System.Drawing.Point(158, 139);
            this.cbox_level.Name = "cbox_level";
            this.cbox_level.Size = new System.Drawing.Size(178, 21);
            this.cbox_level.TabIndex = 7;
            // 
            // txt_add_password
            // 
            this.txt_add_password.Location = new System.Drawing.Point(158, 87);
            this.txt_add_password.Name = "txt_add_password";
            this.txt_add_password.Size = new System.Drawing.Size(178, 20);
            this.txt_add_password.TabIndex = 6;
            // 
            // txt_add_username
            // 
            this.txt_add_username.Location = new System.Drawing.Point(158, 113);
            this.txt_add_username.Name = "txt_add_username";
            this.txt_add_username.Size = new System.Drawing.Size(178, 20);
            this.txt_add_username.TabIndex = 5;
            // 
            // txt_add_login
            // 
            this.txt_add_login.Location = new System.Drawing.Point(158, 61);
            this.txt_add_login.Name = "txt_add_login";
            this.txt_add_login.Size = new System.Drawing.Size(178, 20);
            this.txt_add_login.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MẬT KHẨU :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TÊN NGƯỜI DÙNG :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CẤP ĐỘ NHÂN SỰ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN ĐĂNG NHẬP :";
            // 
            // f_adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 236);
            this.Controls.Add(this.groupBox1);
            this.Name = "f_adduser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM NHÂN SỰ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_add_password;
        private System.Windows.Forms.TextBox txt_add_username;
        private System.Windows.Forms.TextBox txt_add_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_level;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add_user;
    }
}