using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaKhoa.BUS;
using NhaKhoa.Models;

namespace NhaKhoa
{
    public partial class FRM_Lamsan : Form
    {
        private string _maBN;
        private readonly BenhNhanBUS _benhNhanBus;
        private readonly ChuanDoanBUS _chuanDoanBus;

        public FRM_Lamsan(string maBN)
        {
            InitializeComponent();
            _maBN = maBN;
            _benhNhanBus = new BenhNhanBUS();
            _chuanDoanBus = new ChuanDoanBUS();
            LoadThongTinBenhNhan();
            LoadDanhSachLamSan();
        }
        private void LoadThongTinBenhNhan()
        {
            try
            {
                var bn = _benhNhanBus.LayBenhNhanTheoMa(_maBN);
                if (bn != null)
                {
                    lblMaBN.Text = bn.MaBN;
                    lblTenBN.Text = bn.TenBN;
                    lblNgaySinh.Text = bn.NamSinh.ToString();
                    lblGioiTinh.Text = bn.GioiTinh;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDanhSachLamSan()
        {
            try
            {
                var list = _chuanDoanBus.LayChuanDoanTheoMaBN(_maBN);
                var dt = new DataTable();
                dt.Columns.Add("Mã chẩn đoán", typeof(string));
                dt.Columns.Add("Chẩn đoán", typeof(string));
                dt.Columns.Add("Ngày khám", typeof(DateTime));

                foreach (var cd in list)
                {
                    dt.Rows.Add(cd.MaCD, cd.NoiDung, cd.NgayChuanDoan);
                }

                dgvLamSan.DataSource = dt;

                // Định dạng ngày
                if (dgvLamSan.Columns["Ngày khám"] != null)
                {
                    dgvLamSan.Columns["Ngày khám"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemLamSan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtChanDoan.Text))
                {
                    MessageBox.Show("Vui lòng nhập nội dung chẩn đoán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var chuanDoan = new Models.ChuanDoan
                {
                    MaCD = "", // BUS sẽ tự sinh
                    NoiDung = txtChanDoan.Text.Trim(),
                    NgayChuanDoan = DateTime.Now,
                    MaBN = _maBN,
                    MaNV = "NV001", // TODO: Lấy từ user đang đăng nhập
                    MaTLS = null
                };

                _chuanDoanBus.ThemChuanDoan(chuanDoan);
                MessageBox.Show("Thêm chẩn đoán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChanDoan.Clear();
                LoadDanhSachLamSan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLamSan.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một chẩn đoán để xóa!");
                    return;
                }

                string maCD = dgvLamSan.SelectedRows[0].Cells["Mã chẩn đoán"].Value.ToString();

                var result = MessageBox.Show($"Bạn có chắc muốn xóa chẩn đoán {maCD}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;

                _chuanDoanBus.XoaChuanDoan(maCD);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachLamSan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInToaThuoc_Click(object sender, EventArgs e)
        {
            string toaThuoc = $"TOA THUỐC\n\n" +
                      $"Bệnh nhân: {lblTenBN.Text} ({lblMaBN.Text})\n" +
                      $"Ngày sinh: {lblNgaySinh.Text}\n" +
                      $"Giới tính: {lblGioiTinh.Text}\n\n" +
                      $"Chẩn đoán:\n";

            foreach (DataGridViewRow row in dgvLamSan.Rows)
            {
                toaThuoc += $"- {row.Cells["Chẩn đoán"].Value}\n";
            }

            MessageBox.Show(toaThuoc, "Toa thuốc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
