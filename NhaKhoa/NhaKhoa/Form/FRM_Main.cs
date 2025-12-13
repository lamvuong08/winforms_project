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
        public frmMain()
        {
            InitializeComponent();
            UC_Menu menu = new UC_Menu();
            menu.Dock = DockStyle.Left;
            this.Controls.Add(menu);
        }

        

        //Mở form con
        private void OpenSubForm(Form SubForm)
        {
            this.Hide();
            SubForm.ShowDialog();
            this.Show();
            SubForm.Dispose();
        }

        //Form đặt lịch
        private void mnuDatlich_Click(object sender, EventArgs e)
        {
            OpenSubForm(new frmDatlich());
        }
    }
}
