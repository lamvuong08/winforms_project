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

        }
    }
}
