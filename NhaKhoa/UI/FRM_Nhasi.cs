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

namespace NhaKhoa.NhaSi
{
    public partial class FRM_Nhasi : Form
    {
        private readonly BenhNhanBUS _benhNhanBus;

        public FRM_Nhasi()
        {
            InitializeComponent();
            _benhNhanBus = new BenhNhanBUS();
        }
        private void FRM_Nhasi_Load(object sender, EventArgs e)
        {
            LoadDanhSachBenhNhan();
            dgvBenhNhan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBenhNhan.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);

            dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvBenhNhan.Columns["NgayKham"] != null)
            {
                dgvBenhNhan.Columns["NgayKham"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            SetColumnHeaders();
        }
        private void SetColumnHeaders()
        {
            if (dgvBenhNhan.Columns["MaBN"] != null) dgvBenhNhan.Columns["MaBN"].HeaderText = "Mã BN";
            if (dgvBenhNhan.Columns["TenBN"] != null) dgvBenhNhan.Columns["TenBN"].HeaderText = "Tên bệnh nhân";
            if (dgvBenhNhan.Columns["GioiTinh"] != null) dgvBenhNhan.Columns["GioiTinh"].HeaderText = "Giới tính";
            if (dgvBenhNhan.Columns["NamSinh"] != null) dgvBenhNhan.Columns["NamSinh"].HeaderText = "Năm sinh";
            if (dgvBenhNhan.Columns["SDT"] != null) dgvBenhNhan.Columns["SDT"].HeaderText = "SĐT";
            if (dgvBenhNhan.Columns["DiaChi"] != null) dgvBenhNhan.Columns["DiaChi"].HeaderText = "Địa chỉ";
            if (dgvBenhNhan.Columns["NgayKham"] != null) dgvBenhNhan.Columns["NgayKham"].HeaderText = "Ngày khám";
            if (dgvBenhNhan.Columns["LyDoKham"] != null) dgvBenhNhan.Columns["LyDoKham"].HeaderText = "Lý do khám";
        }

        private void LoadDanhSachBenhNhan(string ma = "", string ten = "", string sdt = "")
        {
            try
            {
                // Lấy danh sách chờ khám, sau đó filter theo điều kiện
                var list = _benhNhanBus.LayDanhSachChoKham("Chờ khám");

                // Filter thêm theo điều kiện tìm kiếm
                if (!string.IsNullOrEmpty(ma))
                    list = list.Where(x => x.MaBN.Contains(ma)).ToList();
                if (!string.IsNullOrEmpty(ten))
                    list = list.Where(x => x.TenBN.Contains(ten)).ToList();
                if (!string.IsNullOrEmpty(sdt))
                    list = list.Where(x => x.SDT != null && x.SDT.Contains(sdt)).ToList();

                var dt = new DataTable();
                dt.Columns.Add("MaBN", typeof(string));
                dt.Columns.Add("TenBN", typeof(string));
                dt.Columns.Add("GioiTinh", typeof(string));
                dt.Columns.Add("NamSinh", typeof(int));
                dt.Columns.Add("SDT", typeof(string));
                dt.Columns.Add("DiaChi", typeof(string));
                dt.Columns.Add("NgayKham", typeof(DateTime));
                dt.Columns.Add("LyDoKham", typeof(string));

                foreach (var bn in list)
                {
                    dt.Rows.Add(bn.MaBN, bn.TenBN, bn.GioiTinh, bn.NamSinh, bn.SDT, bn.DiaChi, bn.NgayKham, bn.LyDoKham);
                }

                dgvBenhNhan.DataSource = dt;
                SetColumnHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtTimKiemMa.Text.Trim();
            string ten = txtTimKiemTen.Text.Trim();
            string sdt = txtTimKiemSDT.Text.Trim();

            LoadDanhSachBenhNhan(ma, ten, sdt);
        }

        private void btnChiTietLamSan_Click(object sender, EventArgs e)
        {
            if (dgvBenhNhan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bệnh nhân!");
                return;
            }

            string maBN = dgvBenhNhan.SelectedRows[0].Cells["MaBN"].Value.ToString();

            FRM_Lamsan frm = new FRM_Lamsan(maBN);
            frm.ShowDialog();
        } 
    }
}
