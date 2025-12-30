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

namespace NhaKhoa.Hoadon
{
    public partial class FRM_AddHoadon : Form
    {
        public FRM_AddHoadon()
        {
            InitializeComponent();
        }
        public FRM_AddHoadon(string maBN,string tenBN, DateTime ngaySinh)
        {
            InitializeComponent();
            
            txtMaBN_HD.Text = maBN;
            txtTenBN_HD.Text = tenBN;
            dtp_NgaySinh_HD.Value = ngaySinh;
        }
        private void FRM_AddHoadon_Load(object sender, EventArgs e)
        {

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            dtp_NgaySinh_HD.Value = DateTime.Now;
            dtpNgayLap_HD.Value = DateTime.Now;
            txtMaBN_HD.DataSource = null;
            txtTenBN_HD.Clear();
            cmbMaNV_HD.SelectedIndex = -1;
            txtChucVU_HD.Clear();
            txtTenNV_HD.Clear();
        }

        private void btnSave_HD_Click(object sender, EventArgs e)
        {

        }
    }
}
