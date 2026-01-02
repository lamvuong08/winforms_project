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

namespace NhaKhoa.DoanhThu
{
    public partial class FRM_DoanhThu : Form
    {
        public FRM_DoanhThu()
        {
            InitializeComponent();
        }

        private void FRM_DoanhThu_Load(object sender, EventArgs e)
        {
            CapNhatDoanhThu();
            CapNhatDoanhThuAsync();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CapNhatDoanhThu()
        {
            try
            {
                using (var context = new NhaKhoa.DAL.NhaKhoaContext())
                {
                    // Lấy năm hiện tại
                    int namHienTai = DateTime.Now.Year;
                    int thangHienTai = DateTime.Now.Month;

                    // Tính tổng doanh thu năm
                    var tongDoanhThuNam = context.HoaDons
                        .Where(h => h.NgayLap.HasValue && h.NgayLap.Value.Year == namHienTai)
                        .Sum(h => h.TongTien ?? 0);

                    // Tính tổng doanh thu tháng hiện tại
                    var tongDoanhThuThang = context.HoaDons
                        .Where(h => h.NgayLap.HasValue &&
                                    h.NgayLap.Value.Year == namHienTai &&
                                    h.NgayLap.Value.Month == thangHienTai)
                        .Sum(h => h.TongTien ?? 0);

                    // Hiển thị lên label (giả sử bạn có lblDoanhThuNam và lblDoanhThuThang)
                    txtDTNam_DT.Text = tongDoanhThuNam.ToString("C0"); // Định dạng tiền tệ
                    txtDTThang_DT.Text = tongDoanhThuThang.ToString("C0");

                    // Cập nhật DataGridView với danh sách hóa đơn trong tháng hiện tại
                    var hoaDonThang = context.HoaDons
                        .Where(h => h.NgayLap.HasValue &&
                                    h.NgayLap.Value.Year == namHienTai &&
                                    h.NgayLap.Value.Month == thangHienTai)
                        .Select(h => new
                        {
                            MaHoaDon = h.MaHD,
                            NgayLap = h.NgayLap.HasValue ? h.NgayLap.Value.ToString("dd/MM/yyyy") : "",
                            TenBenhNhan = h.BenhNhan?.TenBN ?? "Không rõ",
                            TongTien = h.TongTien.HasValue ? h.TongTien.Value.ToString("C0") : "0 ₫"
                        })
                        .ToList();

                    dgvThongKe_DT.DataSource = hoaDonThang;
                    dgvThongKe_DT.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thống kê doanh thu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void CapNhatDoanhThuAsync()
        {
            try
            {
                // Hiển thị trạng thái "Đang thống kê..."
                txtDTNam_DT.Text = "Đang thống kê...";
                txtDTThang_DT.Text = "Đang thống kê...";
                dgvThongKe_DT.DataSource = null;

                await Task.Run(() =>
                {
                    using (var context = new NhaKhoa.DAL.NhaKhoaContext())
                    {
                        int namHienTai = DateTime.Now.Year;
                        int thangHienTai = DateTime.Now.Month;

                        var tongDoanhThuNam = context.HoaDons
                            .Where(h => h.NgayLap.HasValue && h.NgayLap.Value.Year == namHienTai)
                            .Sum(h => h.TongTien ?? 0);

                        var tongDoanhThuThang = context.HoaDons
                            .Where(h => h.NgayLap.HasValue &&
                                        h.NgayLap.Value.Year == namHienTai &&
                                        h.NgayLap.Value.Month == thangHienTai)
                            .Sum(h => h.TongTien ?? 0);

                        var hoaDonThang = context.HoaDons
                            .Where(h => h.NgayLap.HasValue &&
                                        h.NgayLap.Value.Year == namHienTai &&
                                        h.NgayLap.Value.Month == thangHienTai)
                            .Select(h => new
                            {
                                MaHoaDon = h.MaHD,
                                NgayLap = h.NgayLap.HasValue ? h.NgayLap.Value.ToString("dd/MM/yyyy") : "",
                                TenBenhNhan = h.BenhNhan?.TenBN ?? "Không rõ",
                                TongTien = h.TongTien.HasValue ? h.TongTien.Value.ToString("C0") : "0 ₫"
                            })
                            .ToList();

                        // Cập nhật UI trên luồng chính
                        this.Invoke((MethodInvoker)delegate
                        {
                            txtDTNam_DT.Text = tongDoanhThuNam.ToString("C0");
                            txtDTThang_DT.Text = tongDoanhThuThang.ToString("C0");
                            dgvThongKe_DT.DataSource = hoaDonThang;
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($"Lỗi khi thống kê doanh thu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDTNam_DT.Text = "Lỗi!";
                    txtDTThang_DT.Text = "Lỗi!";
                });
            }
        }

        private void btnAddDB_DT_Click(object sender, EventArgs e)
        {
            CapNhatDoanhThu();
            CapNhatDoanhThuAsync();
        }
    }
}
