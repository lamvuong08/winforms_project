using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaKhoa.Models;
using NhaKhoa.DAL;

namespace NhaKhoa.NhaSi
{
    public partial class FRM_Nhasi : Form
    {
        public FRM_Nhasi()
        {
            InitializeComponent();
            this.Load += FRM_Nhasi_Load;
        }

        private void dgvDSBN_NhaSi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDSBN_NhaSi.Rows[e.RowIndex];
                var benhNhan = row.DataBoundItem as BenhNhan;

                if (benhNhan != null)
                {
                    // Ví dụ: Hiển thị thông tin
                    MessageBox.Show($"Khám cho: {benhNhan.TenBN}\nLý do: {benhNhan.LyDoKham}","Thông tin bệnh nhân", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FRM_Nhasi_Load(object sender, EventArgs e)
        {
            HienThiDanhSachChoKham();
        }
        private void HienThiDanhSachChoKham()
        {
            try
            {
                var danhSach = LayDanhSachChoKham();

                // Gán dữ liệu vào DataGridView
                dgvDSBN_NhaSi.DataSource = danhSach;

                // Tùy chỉnh cột
                if (dgvDSBN_NhaSi.Columns["MaBN"] != null) dgvDSBN_NhaSi.Columns["MaBN"].Visible = false;
                if (dgvDSBN_NhaSi.Columns["TrangThai"] != null) dgvDSBN_NhaSi.Columns["TrangThai"].Visible = false;

                // Đặt tiêu đề cột
                dgvDSBN_NhaSi.Columns["TenBN"].HeaderText = "Tên bệnh nhân";
                dgvDSBN_NhaSi.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvDSBN_NhaSi.Columns["NamSinh"].HeaderText = "Năm sinh";
                dgvDSBN_NhaSi.Columns["SDT"].HeaderText = "SDT";
                dgvDSBN_NhaSi.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvDSBN_NhaSi.Columns["NgayKham"].HeaderText = "Ngày khám";
                dgvDSBN_NhaSi.Columns["LyDoKham"].HeaderText = "Lí do khám";

                // Định dạng ngày giờ
                dgvDSBN_NhaSi.Columns["NgayKham"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải danh sách bệnh nhân:\n{ex.Message}",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<BenhNhan> LayDanhSachChoKham()
        {
            using (var context = new NhaKhoaContext())
            {
                return context.BenhNhans
                    .Where(bn => bn.TrangThai == "Chờ khám")
                    .ToList();
            }
        }
    }
}
