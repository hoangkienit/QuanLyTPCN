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
    public partial class GUI_XoaPhieuXuat : Form
    {
        BUSL_PhieuXuat phieuXuat = new BUSL_PhieuXuat();
        public GUI_XoaPhieuXuat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI_QuanLyPhieuXuat newForm = new GUI_QuanLyPhieuXuat();
            newForm.Show();
            this.Hide();

        }

        private void GUI_XoaPhieuXuat_Load(object sender, EventArgs e)
        {
            dsPXView.DataSource = phieuXuat.GetPhieuXuat();
        }

        private void xoaPXBtn_Click(object sender, EventArgs e)
        {
            if(phieuXuat.XoaPhieuXuat(maPXBox.Text))
            {
                MessageBox.Show("Xóa thành công");
                dsPXView.DataSource = phieuXuat.GetPhieuXuat();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa");
            }
        }
    }
}
