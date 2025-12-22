using NhaKhoa.Hoadon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaKhoa.Letan
{
    public partial class FRM_Letan : Form
    {
        public FRM_Letan()
        {
            InitializeComponent();
        }

        //kiem tra dau vao
        private bool KiemTraDauVao()
        {
            if (string.IsNullOrWhiteSpace(txtTenBenhNhan_LT.Text))
            {
                MessageBox.Show("Vui lòng nhập tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenBenhNhan_LT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT_LT.Text))
            {
                MessageBox.Show("Vui lòng nhập SDT.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT_LT.Focus();
                return false;
            }
            if (dtp_NgaySinh_LT.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_NgaySinh_LT.Focus();
                return false;
            }
            return true;
        }
        private void FRM_Letan_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_LT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBN_LT.Text)) { 
                MessageBox.Show("Vui lòng nhập mã bệnh nhân cần tìm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaBN_LT.Focus();
                return;
            }
            // Thực hiện tìm kiếm bệnh nhân theo mã bệnh nhân
            string maBN = txtMaBN_LT.Text.Trim();
            var danhSachBenhNhan = new List<BenhNhan>
            {
                new NhaKhoa.BenhNhan { MaBN = "BN001", TenBN = "Nguyễn Văn A", SDT = "0901234567", DiaChi = "Hà Nội", NgaySinh = new DateTime(1990, 5, 15), GioiTinh = "Nam", NgayKham = new DateTime(2025, 12, 23), LyDoKham = "Khám tổng quát" },
                new BenhNhan { MaBN = "BN002", TenBN = "Trần Thị B", SDT = "0902345678", DiaChi = "Hồ Chí Minh", NgaySinh = new DateTime(1985, 8, 20), GioiTinh = "Nữ", NgayKham = new DateTime(2025, 12, 22), LyDoKham = "Đau dạ dày" },
                new BenhNhan { MaBN = "BN003", TenBN = "Lê Văn C", SDT = "0903456789", DiaChi = "Đà Nẵng", NgaySinh = new DateTime(2000, 3, 10), GioiTinh = "Nam", NgayKham = new DateTime(2025, 12, 21), LyDoKham = "Cảm lạnh" }
            };
            var benhNhanTimThay = danhSachBenhNhan.FirstOrDefault(bn => bn.MaBN.Equals(maBN, StringComparison.OrdinalIgnoreCase));
            if (benhNhanTimThay != null)
            {
                //hien thi thong tin benh nhan len toool
                txtTenBenhNhan_LT.Text = benhNhanTimThay.TenBN;
                txtSDT_LT.Text = benhNhanTimThay.SDT;
                txtDiaChi_LT.Text = benhNhanTimThay.DiaChi;
                dtp_NgaySinh_LT.Value = benhNhanTimThay.NgaySinh;
                if (benhNhanTimThay.GioiTinh == "Nam")
                {
                    rboNam_LT.Checked = true;
                }
                else
                {
                    rboNu_LT.Checked = true;
                }
                dtpNgayKham_LT.Value = benhNhanTimThay.NgayKham;
                rtb_LyDoKham_LT.Text = benhNhanTimThay.LyDoKham;
            }
            else
            {
                MessageBox.Show("Không tìm thấy bệnh nhân với mã đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //hien thi thong tin benh nhan tren datagridview
            dgvDSBN.Rows.Clear(); // Xóa dữ liệu cũ trước khi thêm mới

            int rowIndex = dgvDSBN.Rows.Add();
            var row = dgvDSBN.Rows[rowIndex];

            row.Cells["MaBN"].Value = benhNhanTimThay.MaBN;          // Thay "colMaBN" bằng tên cột thực tế trong DataGridView
            row.Cells["TenBN"].Value = benhNhanTimThay.TenBN;
            row.Cells["SDT"].Value = benhNhanTimThay.SDT;
            row.Cells["GioiTinh"].Value = benhNhanTimThay.GioiTinh;
            row.Cells["NamSinh"].Value = benhNhanTimThay.NgaySinh.Year;
            row.Cells["DiaChi"].Value = benhNhanTimThay.DiaChi;
            row.Cells["NgayKham"].Value = benhNhanTimThay.NgayKham.ToShortDateString();
            row.Cells["GhiChu"].Value = benhNhanTimThay.LyDoKham;

            // Optional: Tự động cuộn đến dòng vừa thêm
            dgvDSBN.FirstDisplayedScrollingRowIndex = rowIndex;
        }

        private void btnThemHD_LT_Click(object sender, EventArgs e)
        {
            if (!KiemTraDauVao())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Thêm hóa đơn mới
            string maBN = txtMaBN_LT.Text.Trim();
            string tenBN = txtTenBenhNhan_LT.Text.Trim();
            DateTime ngaySinh = dtp_NgaySinh_LT.Value;
            string gioiTinh = rboNam_LT.Checked ? "Nam" : "Nữ"; // Giả định bạn dùng RadioButton
            string sdt = txtSDT_LT.Text.Trim();
            string diaChi = txtDiaChi_LT.Text.Trim();
            /*FRM_AddHoadon frmAddHoadon = new FRM_AddHoadon(maBN, tenBN, ngaySinh, gioiTinh, sdt, diaChi);
            *frmAddHoadon.ShowDialog();
            *tao instance cua form hoa don va truyen du lieu benh nhan vao
            *hien thi form hoa don
            */
        }

        private void btnThemChiTietHD_LT_Click(object sender, EventArgs e)
        {

        }

        private void btnThemLich_LT_Click(object sender, EventArgs e)
        {
            if (!KiemTraDauVao())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Thêm lịch hẹn mới
            // Thêm vào danh sách
            

            // Thêm dòng mới vào DataGridView (giả sử tên dgvDanhSach)
            int index = dgvDSBN.Rows.Add();
            dgvDSBN.Rows[index].Cells["MaBN"].Value = txtMaBN_LT.Text.Trim();
            dgvDSBN.Rows[index].Cells["TenBN"].Value = txtTenBenhNhan_LT.Text.Trim();
            dgvDSBN.Rows[index].Cells["SDT"].Value = txtSDT_LT.Text.Trim();
            dgvDSBN.Rows[index].Cells["GioiTinh"].Value = rboNam_LT.Checked ? "Nam" : "Nữ";
            dgvDSBN.Rows[index].Cells["NamSinh"].Value = dtp_NgaySinh_LT.Value.Year;
            dgvDSBN.Rows[index].Cells["DiaChi"].Value = txtDiaChi_LT.Text.Trim();
            dgvDSBN.Rows[index].Cells["NgayKham"].Value = dtpNgayKham_LT.Value.ToShortDateString();
            dgvDSBN.Rows[index].Cells["GhiChu"].Value = rtb_LyDoKham_LT.Text.Trim();
            // Thông báo thành công
            MessageBox.Show("Lịch hẹn đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
