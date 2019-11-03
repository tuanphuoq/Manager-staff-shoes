namespace ProjectHQT
{
    partial class f_pay
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
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_guest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idshoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nUD_quantity = new System.Windows.Forms.NumericUpDown();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(30, 131);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(453, 139);
            this.dgvBill.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "THANH TOÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÊN KHÁCH HÀNG :";
            // 
            // txt_guest
            // 
            this.txt_guest.Location = new System.Drawing.Point(151, 38);
            this.txt_guest.Name = "txt_guest";
            this.txt_guest.Size = new System.Drawing.Size(240, 20);
            this.txt_guest.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MÃ SẢN PHẨM :";
            // 
            // txt_idshoes
            // 
            this.txt_idshoes.Location = new System.Drawing.Point(151, 64);
            this.txt_idshoes.Name = "txt_idshoes";
            this.txt_idshoes.Size = new System.Drawing.Size(100, 20);
            this.txt_idshoes.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SỐ LƯỢNG :";
            // 
            // nUD_quantity
            // 
            this.nUD_quantity.Location = new System.Drawing.Point(348, 65);
            this.nUD_quantity.Name = "nUD_quantity";
            this.nUD_quantity.Size = new System.Drawing.Size(43, 20);
            this.nUD_quantity.TabIndex = 8;
            // 
            // btn_add_item
            // 
            this.btn_add_item.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_add_item.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_item.Location = new System.Drawing.Point(30, 103);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(118, 22);
            this.btn_add_item.TabIndex = 9;
            this.btn_add_item.Text = "THÊM";
            this.btn_add_item.UseVisualStyleBackColor = false;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_pay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_pay.Location = new System.Drawing.Point(30, 276);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(453, 30);
            this.btn_pay.TabIndex = 10;
            this.btn_pay.Text = "XÁC NHẬN THANH TOÁN";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // f_pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 328);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.btn_add_item);
            this.Controls.Add(this.nUD_quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idshoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_guest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBill);
            this.Name = "f_pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THANH TOÁN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_guest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idshoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUD_quantity;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.Button btn_pay;
    }
}