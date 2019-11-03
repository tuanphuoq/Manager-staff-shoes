namespace ProjectHQT
{
    partial class f_manager
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
            this.dgvShoes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_nameshoes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_showall = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_nameuser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delshoes = new System.Windows.Forms.Button();
            this.btn_updateshoes = new System.Windows.Forms.Button();
            this.btn_addshoes = new System.Windows.Forms.Button();
            this.btn_store = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShoes
            // 
            this.dgvShoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoes.Location = new System.Drawing.Point(9, 230);
            this.dgvShoes.Name = "dgvShoes";
            this.dgvShoes.Size = new System.Drawing.Size(518, 215);
            this.dgvShoes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_nameshoes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM SẢN PHẨM";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.Location = new System.Drawing.Point(190, 69);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(87, 26);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "TÌM KIẾM";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_nameshoes
            // 
            this.txt_nameshoes.Location = new System.Drawing.Point(106, 38);
            this.txt_nameshoes.Name = "txt_nameshoes";
            this.txt_nameshoes.Size = new System.Drawing.Size(171, 20);
            this.txt_nameshoes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN SẢN PHẨM :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập mã sản phẩm tìm kiếm";
            // 
            // btn_showall
            // 
            this.btn_showall.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_showall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showall.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_showall.Location = new System.Drawing.Point(9, 198);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(283, 26);
            this.btn_showall.TabIndex = 4;
            this.btn_showall.Text = "HIỂN THỊ TOÀN BỘ SẢN PHẨM";
            this.btn_showall.UseVisualStyleBackColor = false;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "NHẬP KHO VÀ QUẢN LÝ SẢN PHẨM";
            // 
            // lb_nameuser
            // 
            this.lb_nameuser.AutoSize = true;
            this.lb_nameuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nameuser.ForeColor = System.Drawing.Color.Blue;
            this.lb_nameuser.Location = new System.Drawing.Point(172, 62);
            this.lb_nameuser.Name = "lb_nameuser";
            this.lb_nameuser.Size = new System.Drawing.Size(0, 13);
            this.lb_nameuser.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(15, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "NHÂN VIÊN QUẢN LÝ :";
            // 
            // btn_delshoes
            // 
            this.btn_delshoes.BackColor = System.Drawing.Color.Firebrick;
            this.btn_delshoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delshoes.Location = new System.Drawing.Point(358, 188);
            this.btn_delshoes.Name = "btn_delshoes";
            this.btn_delshoes.Size = new System.Drawing.Size(169, 36);
            this.btn_delshoes.TabIndex = 9;
            this.btn_delshoes.Text = "XÓA SẢN PHẨM";
            this.btn_delshoes.UseVisualStyleBackColor = false;
            this.btn_delshoes.Click += new System.EventHandler(this.btn_delshoes_Click);
            // 
            // btn_updateshoes
            // 
            this.btn_updateshoes.BackColor = System.Drawing.Color.Gold;
            this.btn_updateshoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateshoes.Location = new System.Drawing.Point(358, 146);
            this.btn_updateshoes.Name = "btn_updateshoes";
            this.btn_updateshoes.Size = new System.Drawing.Size(169, 36);
            this.btn_updateshoes.TabIndex = 10;
            this.btn_updateshoes.Text = "SỬA SẢN PHẨM";
            this.btn_updateshoes.UseVisualStyleBackColor = false;
            // 
            // btn_addshoes
            // 
            this.btn_addshoes.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_addshoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addshoes.Location = new System.Drawing.Point(358, 62);
            this.btn_addshoes.Name = "btn_addshoes";
            this.btn_addshoes.Size = new System.Drawing.Size(169, 36);
            this.btn_addshoes.TabIndex = 11;
            this.btn_addshoes.Text = "THÊM SẢN PHẨM MỚI";
            this.btn_addshoes.UseVisualStyleBackColor = false;
            // 
            // btn_store
            // 
            this.btn_store.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_store.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_store.Location = new System.Drawing.Point(358, 104);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(169, 36);
            this.btn_store.TabIndex = 12;
            this.btn_store.Text = "NHẬP KHO HÀNG";
            this.btn_store.UseVisualStyleBackColor = false;
            this.btn_store.Click += new System.EventHandler(this.btn_store_Click);
            // 
            // f_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.btn_store);
            this.Controls.Add(this.btn_addshoes);
            this.Controls.Add(this.btn_updateshoes);
            this.Controls.Add(this.btn_delshoes);
            this.Controls.Add(this.lb_nameuser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvShoes);
            this.Name = "f_manager";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.f_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_nameshoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_nameuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_delshoes;
        private System.Windows.Forms.Button btn_updateshoes;
        private System.Windows.Forms.Button btn_addshoes;
        private System.Windows.Forms.Button btn_store;
    }
}