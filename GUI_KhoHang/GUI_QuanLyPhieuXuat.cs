using BUSL_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class GUI_QuanLyPhieuXuat : Form
    {
        BUSL_PhieuXuat phieuXuat = new BUSL_PhieuXuat();
        public GUI_QuanLyPhieuXuat()
        {
            InitializeComponent();
        }

        private void GUI_PhieuXuat_Load(object sender, EventArgs e)
        {
            dsPXView.DataSource = phieuXuat.GetPhieuXuat();
        }

        private void taoBtn_Click(object sender, EventArgs e)
        {
            GUI_TaoPhieuXuat newForm = new GUI_TaoPhieuXuat();
            newForm.Show();
            this.Hide();

        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            GUI_XoaPhieuXuat newForm = new GUI_XoaPhieuXuat();
            newForm.Show();
            this.Hide();
        }
    }
}
