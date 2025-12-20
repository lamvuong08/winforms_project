namespace NhaKhoa.Letan
{
    partial class FRM_Letan
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
            this.btn = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.rtb_LyDoKham_LT = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dtp_NgaySinh_LT = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi_LT = new System.Windows.Forms.TextBox();
            this.txtTenBenhNhan_LT = new System.Windows.Forms.TextBox();
            this.txtSDT_LT = new System.Windows.Forms.TextBox();
            this.txtMaBN_LT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDSBN = new System.Windows.Forms.DataGridView();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem_LT = new System.Windows.Forms.Button();
            this.btnThemHD_LT = new System.Windows.Forms.Button();
            this.btnThemChiTietHD_LT = new System.Windows.Forms.Button();
            this.btnThemLich_LT = new System.Windows.Forms.Button();
            this.btnNhapLai_LT = new System.Windows.Forms.Button();
            this.btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(737, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "PHIẾU KHÁM BỆNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin phiếu khám";
            // 
            // btn
            // 
            this.btn.Controls.Add(this.dateTimePicker2);
            this.btn.Controls.Add(this.label9);
            this.btn.Controls.Add(this.rtb_LyDoKham_LT);
            this.btn.Controls.Add(this.label8);
            this.btn.Controls.Add(this.radioButton2);
            this.btn.Controls.Add(this.radioButton1);
            this.btn.Controls.Add(this.dtp_NgaySinh_LT);
            this.btn.Controls.Add(this.txtDiaChi_LT);
            this.btn.Controls.Add(this.txtTenBenhNhan_LT);
            this.btn.Controls.Add(this.txtSDT_LT);
            this.btn.Controls.Add(this.txtMaBN_LT);
            this.btn.Controls.Add(this.label5);
            this.btn.Controls.Add(this.label6);
            this.btn.Controls.Add(this.label7);
            this.btn.Controls.Add(this.label4);
            this.btn.Controls.Add(this.label3);
            this.btn.Controls.Add(this.label10);
            this.btn.Location = new System.Drawing.Point(275, 181);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(1475, 341);
            this.btn.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(827, 32);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(317, 22);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(717, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "ngày khám:";
            // 
            // rtb_LyDoKham_LT
            // 
            this.rtb_LyDoKham_LT.Location = new System.Drawing.Point(827, 105);
            this.rtb_LyDoKham_LT.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_LyDoKham_LT.Name = "rtb_LyDoKham_LT";
            this.rtb_LyDoKham_LT.Size = new System.Drawing.Size(372, 130);
            this.rtb_LyDoKham_LT.TabIndex = 15;
            this.rtb_LyDoKham_LT.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(717, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Lý do khám";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(307, 294);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(192, 294);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 20);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dtp_NgaySinh_LT
            // 
            this.dtp_NgaySinh_LT.Location = new System.Drawing.Point(192, 241);
            this.dtp_NgaySinh_LT.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgaySinh_LT.Name = "dtp_NgaySinh_LT";
            this.dtp_NgaySinh_LT.Size = new System.Drawing.Size(317, 22);
            this.dtp_NgaySinh_LT.TabIndex = 10;
            // 
            // txtDiaChi_LT
            // 
            this.txtDiaChi_LT.Location = new System.Drawing.Point(192, 186);
            this.txtDiaChi_LT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi_LT.Name = "txtDiaChi_LT";
            this.txtDiaChi_LT.Size = new System.Drawing.Size(317, 22);
            this.txtDiaChi_LT.TabIndex = 9;
            // 
            // txtTenBenhNhan_LT
            // 
            this.txtTenBenhNhan_LT.Location = new System.Drawing.Point(192, 82);
            this.txtTenBenhNhan_LT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBenhNhan_LT.Name = "txtTenBenhNhan_LT";
            this.txtTenBenhNhan_LT.Size = new System.Drawing.Size(317, 22);
            this.txtTenBenhNhan_LT.TabIndex = 8;
            // 
            // txtSDT_LT
            // 
            this.txtSDT_LT.Location = new System.Drawing.Point(192, 135);
            this.txtSDT_LT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT_LT.Name = "txtSDT_LT";
            this.txtSDT_LT.Size = new System.Drawing.Size(317, 22);
            this.txtSDT_LT.TabIndex = 7;
            // 
            // txtMaBN_LT
            // 
            this.txtMaBN_LT.Location = new System.Drawing.Point(192, 31);
            this.txtMaBN_LT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBN_LT.Name = "txtMaBN_LT";
            this.txtMaBN_LT.Size = new System.Drawing.Size(317, 22);
            this.txtMaBN_LT.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(44, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(44, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(44, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(44, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(44, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên bệnh nhân";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(44, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã bệnh nhân";
            // 
            // dgvDSBN
            // 
            this.dgvDSBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.TenBN,
            this.GioiTinh,
            this.NamSinh,
            this.SDT,
            this.DiaChi,
            this.NgayTao,
            this.Column1});
            this.dgvDSBN.Location = new System.Drawing.Point(220, 619);
            this.dgvDSBN.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSBN.Name = "dgvDSBN";
            this.dgvDSBN.RowHeadersWidth = 51;
            this.dgvDSBN.Size = new System.Drawing.Size(1601, 506);
            this.dgvDSBN.TabIndex = 9;
            // 
            // MaBN
            // 
            this.MaBN.HeaderText = "Mã bệnh nhân";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            // 
            // TenBN
            // 
            this.TenBN.HeaderText = "Tên bệnh nhân";
            this.TenBN.MinimumWidth = 6;
            this.TenBN.Name = "TenBN";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NamSinh
            // 
            this.NamSinh.HeaderText = "Ngày sinh";
            this.NamSinh.MinimumWidth = 6;
            this.NamSinh.Name = "NamSinh";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // NgayTao
            // 
            this.NgayTao.HeaderText = "Ngày khám";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ghi chú";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // btnTimKiem_LT
            // 
            this.btnTimKiem_LT.Location = new System.Drawing.Point(313, 565);
            this.btnTimKiem_LT.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem_LT.Name = "btnTimKiem_LT";
            this.btnTimKiem_LT.Size = new System.Drawing.Size(127, 37);
            this.btnTimKiem_LT.TabIndex = 10;
            this.btnTimKiem_LT.Text = "Tìm kiếm";
            this.btnTimKiem_LT.UseVisualStyleBackColor = true;
            this.btnTimKiem_LT.Click += new System.EventHandler(this.btnTimKiem_LT_Click);
            // 
            // btnThemHD_LT
            // 
            this.btnThemHD_LT.Location = new System.Drawing.Point(512, 565);
            this.btnThemHD_LT.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemHD_LT.Name = "btnThemHD_LT";
            this.btnThemHD_LT.Size = new System.Drawing.Size(173, 37);
            this.btnThemHD_LT.TabIndex = 11;
            this.btnThemHD_LT.Text = "Thêm mới hoá đơn";
            this.btnThemHD_LT.UseVisualStyleBackColor = true;
            // 
            // btnThemChiTietHD_LT
            // 
            this.btnThemChiTietHD_LT.Location = new System.Drawing.Point(779, 565);
            this.btnThemChiTietHD_LT.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemChiTietHD_LT.Name = "btnThemChiTietHD_LT";
            this.btnThemChiTietHD_LT.Size = new System.Drawing.Size(189, 37);
            this.btnThemChiTietHD_LT.TabIndex = 12;
            this.btnThemChiTietHD_LT.Text = "Thêm mới chi tiết hoá đơn";
            this.btnThemChiTietHD_LT.UseVisualStyleBackColor = true;
            // 
            // btnThemLich_LT
            // 
            this.btnThemLich_LT.Location = new System.Drawing.Point(1048, 565);
            this.btnThemLich_LT.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLich_LT.Name = "btnThemLich_LT";
            this.btnThemLich_LT.Size = new System.Drawing.Size(173, 37);
            this.btnThemLich_LT.TabIndex = 13;
            this.btnThemLich_LT.Text = "Thêm mới lịch hẹn";
            this.btnThemLich_LT.UseVisualStyleBackColor = true;
            // 
            // btnNhapLai_LT
            // 
            this.btnNhapLai_LT.Location = new System.Drawing.Point(1316, 565);
            this.btnNhapLai_LT.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapLai_LT.Name = "btnNhapLai_LT";
            this.btnNhapLai_LT.Size = new System.Drawing.Size(120, 37);
            this.btnNhapLai_LT.TabIndex = 14;
            this.btnNhapLai_LT.Text = "Nhập lại";
            this.btnNhapLai_LT.UseVisualStyleBackColor = true;
            // 
            // FRM_Letan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnNhapLai_LT);
            this.Controls.Add(this.btnThemLich_LT);
            this.Controls.Add(this.btnThemChiTietHD_LT);
            this.Controls.Add(this.btnThemHD_LT);
            this.Controls.Add(this.btnTimKiem_LT);
            this.Controls.Add(this.dgvDSBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Letan";
            this.Text = "Lễ tân";
            this.Load += new System.EventHandler(this.FRM_Letan_Load);
            this.btn.ResumeLayout(false);
            this.btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtb_LyDoKham_LT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh_LT;
        private System.Windows.Forms.TextBox txtDiaChi_LT;
        private System.Windows.Forms.TextBox txtTenBenhNhan_LT;
        private System.Windows.Forms.TextBox txtSDT_LT;
        private System.Windows.Forms.TextBox txtMaBN_LT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDSBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnTimKiem_LT;
        private System.Windows.Forms.Button btnThemHD_LT;
        private System.Windows.Forms.Button btnThemChiTietHD_LT;
        private System.Windows.Forms.Button btnThemLich_LT;
        private System.Windows.Forms.Button btnNhapLai_LT;
    }
}