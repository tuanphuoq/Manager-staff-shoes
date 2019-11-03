namespace ProjectHQT
{
    partial class f_store
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
            this.btn_store_exit = new System.Windows.Forms.Button();
            this.btn_store_shoes = new System.Windows.Forms.Button();
            this.lb_announce = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_shoesid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_store_exit);
            this.groupBox1.Controls.Add(this.btn_store_shoes);
            this.groupBox1.Controls.Add(this.lb_announce);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.txt_shoesid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NHẬP KHO";
            // 
            // btn_store_exit
            // 
            this.btn_store_exit.BackColor = System.Drawing.Color.Brown;
            this.btn_store_exit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_store_exit.Location = new System.Drawing.Point(215, 122);
            this.btn_store_exit.Name = "btn_store_exit";
            this.btn_store_exit.Size = new System.Drawing.Size(157, 29);
            this.btn_store_exit.TabIndex = 7;
            this.btn_store_exit.Text = "HỦY";
            this.btn_store_exit.UseVisualStyleBackColor = false;
            this.btn_store_exit.Click += new System.EventHandler(this.btn_store_exit_Click);
            // 
            // btn_store_shoes
            // 
            this.btn_store_shoes.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_store_shoes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_store_shoes.Location = new System.Drawing.Point(32, 122);
            this.btn_store_shoes.Name = "btn_store_shoes";
            this.btn_store_shoes.Size = new System.Drawing.Size(157, 29);
            this.btn_store_shoes.TabIndex = 6;
            this.btn_store_shoes.Text = "NHẬP KHO";
            this.btn_store_shoes.UseVisualStyleBackColor = false;
            this.btn_store_shoes.Click += new System.EventHandler(this.btn_store_shoes_Click);
            // 
            // lb_announce
            // 
            this.lb_announce.AutoSize = true;
            this.lb_announce.ForeColor = System.Drawing.Color.Red;
            this.lb_announce.Location = new System.Drawing.Point(29, 88);
            this.lb_announce.Name = "lb_announce";
            this.lb_announce.Size = new System.Drawing.Size(0, 13);
            this.lb_announce.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "kiểm tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(135, 59);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(160, 20);
            this.txt_quantity.TabIndex = 3;
            // 
            // txt_shoesid
            // 
            this.txt_shoesid.Location = new System.Drawing.Point(135, 24);
            this.txt_shoesid.Name = "txt_shoesid";
            this.txt_shoesid.Size = new System.Drawing.Size(160, 20);
            this.txt_shoesid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "SỐ LƯỢNG NHẬP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "MÃ SẢN PHẨM :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHẬP KHO";
            // 
            // f_store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "f_store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHẬP KHO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_store_exit;
        private System.Windows.Forms.Button btn_store_shoes;
        private System.Windows.Forms.Label lb_announce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_shoesid;
        private System.Windows.Forms.Label label3;
    }
}