namespace ProjectHQT
{
    partial class f_admin
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grbox_info = new System.Windows.Forms.GroupBox();
            this.cbox_level = new System.Windows.Forms.ComboBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_userlogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_updateuser = new System.Windows.Forms.Button();
            this.btn_deluser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grbox_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(14, 194);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(619, 214);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // grbox_info
            // 
            this.grbox_info.Controls.Add(this.cbox_level);
            this.grbox_info.Controls.Add(this.btn_confirm);
            this.grbox_info.Controls.Add(this.txt_username);
            this.grbox_info.Controls.Add(this.txt_userlogin);
            this.grbox_info.Controls.Add(this.label3);
            this.grbox_info.Controls.Add(this.label2);
            this.grbox_info.Controls.Add(this.label1);
            this.grbox_info.Enabled = false;
            this.grbox_info.Location = new System.Drawing.Point(14, 24);
            this.grbox_info.Name = "grbox_info";
            this.grbox_info.Size = new System.Drawing.Size(393, 127);
            this.grbox_info.TabIndex = 1;
            this.grbox_info.TabStop = false;
            this.grbox_info.Text = "TRA CỨU THÔNG TIN NGƯỜI DÙNG";
            // 
            // cbox_level
            // 
            this.cbox_level.FormattingEnabled = true;
            this.cbox_level.Items.AddRange(new object[] {
            "ADMIN",
            "QUẢN LÝ",
            "NHÂN VIÊN"});
            this.cbox_level.Location = new System.Drawing.Point(151, 76);
            this.cbox_level.Name = "cbox_level";
            this.cbox_level.Size = new System.Drawing.Size(163, 21);
            this.cbox_level.TabIndex = 7;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.Green;
            this.btn_confirm.Location = new System.Drawing.Point(151, 103);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(163, 21);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "XÁC NHẬN";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(151, 51);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(163, 20);
            this.txt_username.TabIndex = 4;
            // 
            // txt_userlogin
            // 
            this.txt_userlogin.Location = new System.Drawing.Point(151, 25);
            this.txt_userlogin.Name = "txt_userlogin";
            this.txt_userlogin.Size = new System.Drawing.Size(163, 20);
            this.txt_userlogin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CẤP ĐỘ  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN ĐĂNG NHẬP :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN NGƯỜI DÙNG :";
            // 
            // btn_adduser
            // 
            this.btn_adduser.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adduser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_adduser.Location = new System.Drawing.Point(430, 32);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(203, 33);
            this.btn_adduser.TabIndex = 2;
            this.btn_adduser.Text = "THÊM NGƯỜI DÙNG";
            this.btn_adduser.UseVisualStyleBackColor = false;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "HIỂN THỊ TOÀN BỘ NGƯỜI DÙNG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_updateuser
            // 
            this.btn_updateuser.BackColor = System.Drawing.Color.Gold;
            this.btn_updateuser.Enabled = false;
            this.btn_updateuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateuser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_updateuser.Location = new System.Drawing.Point(430, 75);
            this.btn_updateuser.Name = "btn_updateuser";
            this.btn_updateuser.Size = new System.Drawing.Size(203, 33);
            this.btn_updateuser.TabIndex = 4;
            this.btn_updateuser.Text = "SỬA NGƯỜI DÙNG";
            this.btn_updateuser.UseVisualStyleBackColor = false;
            this.btn_updateuser.Click += new System.EventHandler(this.btn_updateuser_Click);
            // 
            // btn_deluser
            // 
            this.btn_deluser.BackColor = System.Drawing.Color.Brown;
            this.btn_deluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deluser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deluser.Location = new System.Drawing.Point(430, 118);
            this.btn_deluser.Name = "btn_deluser";
            this.btn_deluser.Size = new System.Drawing.Size(203, 33);
            this.btn_deluser.TabIndex = 5;
            this.btn_deluser.Text = "XÓA NGƯỜI DÙNG";
            this.btn_deluser.UseVisualStyleBackColor = false;
            this.btn_deluser.Click += new System.EventHandler(this.btn_deluser_Click);
            // 
            // f_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 416);
            this.Controls.Add(this.btn_deluser);
            this.Controls.Add(this.btn_updateuser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.grbox_info);
            this.Controls.Add(this.dgvUsers);
            this.Name = "f_admin";
            this.Text = "QUẢN LÝ NHÂN SỰ";
            this.Load += new System.EventHandler(this.f_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grbox_info.ResumeLayout(false);
            this.grbox_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grbox_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_userlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_updateuser;
        private System.Windows.Forms.Button btn_deluser;
        private System.Windows.Forms.ComboBox cbox_level;
    }
}