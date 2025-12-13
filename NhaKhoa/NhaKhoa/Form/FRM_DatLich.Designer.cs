namespace NhaKhoa
{
    partial class frmDatlich
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboNgayKham = new System.Windows.Forms.ComboBox();
            this.cboGioKham = new System.Windows.Forms.ComboBox();
            this.dgvLichKham = new System.Windows.Forms.DataGridView();
            this.BacSii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(290, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt Lịch Khám ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bác sĩ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(334, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày khám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(34, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dịch vụ";
            // 
            // cboBacSi
            // 
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(97, 34);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(189, 21);
            this.cboBacSi.TabIndex = 4;
            // 
            // cboDichVu
            // 
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(99, 93);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(187, 21);
            this.cboDichVu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(334, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giờ khám";
            // 
            // cboNgayKham
            // 
            this.cboNgayKham.FormattingEnabled = true;
            this.cboNgayKham.Location = new System.Drawing.Point(416, 34);
            this.cboNgayKham.Name = "cboNgayKham";
            this.cboNgayKham.Size = new System.Drawing.Size(194, 21);
            this.cboNgayKham.TabIndex = 7;
            // 
            // cboGioKham
            // 
            this.cboGioKham.FormattingEnabled = true;
            this.cboGioKham.Location = new System.Drawing.Point(416, 93);
            this.cboGioKham.Name = "cboGioKham";
            this.cboGioKham.Size = new System.Drawing.Size(194, 21);
            this.cboGioKham.TabIndex = 8;
            // 
            // dgvLichKham
            // 
            this.dgvLichKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BacSii,
            this.NgayKham,
            this.GioKham,
            this.DichVu});
            this.dgvLichKham.Location = new System.Drawing.Point(78, 225);
            this.dgvLichKham.Name = "dgvLichKham";
            this.dgvLichKham.ReadOnly = true;
            this.dgvLichKham.Size = new System.Drawing.Size(635, 196);
            this.dgvLichKham.TabIndex = 9;
            // 
            // BacSii
            // 
            this.BacSii.HeaderText = "Bác sĩ";
            this.BacSii.Name = "BacSii";
            // 
            // NgayKham
            // 
            this.NgayKham.HeaderText = "Ngày khám";
            this.NgayKham.Name = "NgayKham";
            // 
            // GioKham
            // 
            this.GioKham.HeaderText = "Giờ khám";
            this.GioKham.Name = "GioKham";
            // 
            // DichVu
            // 
            this.DichVu.HeaderText = "Dịch vụ";
            this.DichVu.Name = "DichVu";
            // 
            // btnLuuSua
            // 
            this.btnLuuSua.Location = new System.Drawing.Point(177, 438);
            this.btnLuuSua.Name = "btnLuuSua";
            this.btnLuuSua.Size = new System.Drawing.Size(96, 39);
            this.btnLuuSua.TabIndex = 10;
            this.btnLuuSua.Text = "Lưu/ Sửa";
            this.btnLuuSua.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboGioKham);
            this.groupBox1.Controls.Add(this.cboNgayKham);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboDichVu);
            this.groupBox1.Controls.Add(this.cboBacSi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(78, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 143);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt Lịch Khám";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(334, 438);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(96, 39);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(494, 438);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 39);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmDatlich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 501);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLuuSua);
            this.Controls.Add(this.dgvLichKham);
            this.Controls.Add(this.label1);
            this.Name = "frmDatlich";
            this.Text = "FRM_DatLich";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNgayKham;
        private System.Windows.Forms.ComboBox cboGioKham;
        private System.Windows.Forms.DataGridView dgvLichKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn BacSii;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVu;
        private System.Windows.Forms.Button btnLuuSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
    }
}