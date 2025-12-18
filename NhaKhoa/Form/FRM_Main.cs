using NhaKhoa.BenhNhan;
using NhaKhoa.NhanVien;
using NhaKhoa.TaiKhoan;
using NhaKhoa.Thuoc;
using NhaKhoa.Vatlieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaKhoa
{
    public partial class frmMain : Form
    {
        private string _userRole;
        private Form _currentContent;

        public frmMain(string role)
        {
            InitializeComponent();
            _userRole = role;

            UC_Menu menu = new UC_Menu();
            menu.Dock = DockStyle.Left;
            menu.SetRoleVisibility(_userRole);

            // ⬇️ BẮT BUỘC PHẢI CÓ DÒNG NÀY:
            menu.MenuItemClicked += UC_Menu_MenuItemClicked; // ← BỎ COMMENT DÒNG NÀY

            this.Controls.Add(menu);
        }

        //Mở form con bên trong panel
        private void ShowContent(Form form)
        {
            // Đóng form hiện tại (nếu có)
            if (_currentContent != null)
            {
                _currentContent.Close(); // hoặc Dispose() nếu không cần giữ trạng thái
                _currentContent = null;
            }

            // Thiết lập form con
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Thêm vào panel và hiển thị
            pnlContent.Controls.Clear(); // Xóa toàn bộ control cũ (an toàn hơn)
            pnlContent.Controls.Add(form);
            form.Show();

            _currentContent = form;
        }

        //Xử lý sự kiện menu
        private void UC_Menu_MenuItemClicked(object sender, MenuItemEventArgs e)
        {
            Form formToOpen = null;

            switch (e.MenuItem)
            {
                case "Taikhoan":
                    formToOpen = new FRM_Account();
                    break;
                case "Benhnhan":
                    formToOpen = new FRM_Benhnhan();
                    break;
                case "Nhanvien":
                    formToOpen = new FRM_Nhanvien();
                    break;
                case "Vatlieu":
                    formToOpen = new FRM_Vatlieu();
                    break;
                case "Thuoc":
                    formToOpen = new FRM_Thuoc();
                    break;
                case "Hoadon":
                    // formToOpen = new frmHoaDon();
                    break;
                case "Doanhthu":
                    // formToOpen = new frmDoanhThu();
                    break;
                case "Datlich":
                    // formToOpen = new frmDatlich();
                    break;
            }

            if (formToOpen != null)
            {
                ShowContent(formToOpen);
            }
        }
    }
}
