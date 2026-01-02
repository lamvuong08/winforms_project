namespace NhaKhoa.DoanhThu
{
    partial class FRM_DoanhThu
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
            this.dgvThongKe_DT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDB_DT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDTNam_DT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDTThang_DT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe_DT)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongKe_DT
            // 
            this.dgvThongKe_DT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.dgvThongKe_DT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe_DT.Location = new System.Drawing.Point(25, 283);
            this.dgvThongKe_DT.Name = "dgvThongKe_DT";
            this.dgvThongKe_DT.RowHeadersWidth = 51;
            this.dgvThongKe_DT.Size = new System.Drawing.Size(980, 255);
            this.dgvThongKe_DT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê doanh thu";
            // 
            // btnAddDB_DT
            // 
            this.btnAddDB_DT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.btnAddDB_DT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddDB_DT.Location = new System.Drawing.Point(25, 558);
            this.btnAddDB_DT.Name = "btnAddDB_DT";
            this.btnAddDB_DT.Size = new System.Drawing.Size(110, 43);
            this.btnAddDB_DT.TabIndex = 3;
            this.btnAddDB_DT.Text = "Cập Nhật";
            this.btnAddDB_DT.UseVisualStyleBackColor = false;
            this.btnAddDB_DT.Click += new System.EventHandler(this.btnAddDB_DT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDTNam_DT);
            this.panel1.Location = new System.Drawing.Point(25, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 100);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doanh thu năm";
            // 
            // txtDTNam_DT
            // 
            this.txtDTNam_DT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDTNam_DT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtDTNam_DT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDTNam_DT.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTNam_DT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtDTNam_DT.Location = new System.Drawing.Point(8, 36);
            this.txtDTNam_DT.Margin = new System.Windows.Forms.Padding(0);
            this.txtDTNam_DT.Name = "txtDTNam_DT";
            this.txtDTNam_DT.Size = new System.Drawing.Size(349, 43);
            this.txtDTNam_DT.TabIndex = 0;
            this.txtDTNam_DT.Text = "Đang thông kê...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.txtDTThang_DT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(648, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 100);
            this.panel2.TabIndex = 5;
            // 
            // txtDTThang_DT
            // 
            this.txtDTThang_DT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDTThang_DT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtDTThang_DT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDTThang_DT.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTThang_DT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtDTThang_DT.Location = new System.Drawing.Point(7, 36);
            this.txtDTThang_DT.Margin = new System.Windows.Forms.Padding(0);
            this.txtDTThang_DT.Name = "txtDTThang_DT";
            this.txtDTThang_DT.Size = new System.Drawing.Size(349, 43);
            this.txtDTThang_DT.TabIndex = 8;
            this.txtDTThang_DT.Text = "Đang thông kê...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doanh thu tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng quan doanh thu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(168, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FRM_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1027, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddDB_DT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongKe_DT);
            this.Name = "FRM_DoanhThu";
            this.Text = "FRM_DoanhThu";
            this.Load += new System.EventHandler(this.FRM_DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe_DT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe_DT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDB_DT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDTNam_DT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDTThang_DT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}