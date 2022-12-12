using BUSL_QuanLy;
using GUI_QuanLy;
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
    public partial class GUI_TrangChu : Form
    {
        BUSL_SanPham sanPham = new BUSL_SanPham();
        public GUI_TrangChu()
        {
            InitializeComponent();
        }

        private void GUI_TrangChu_Load(object sender, EventArgs e)
        {
            sanphamView.DataSource = sanPham.GetSanPham();
        }

        private void qlPNBtn_Click(object sender, EventArgs e)
        {
            GUI_QuanLyPhieuNhap newForm = new GUI_QuanLyPhieuNhap();
            newForm.Show();
            this.Hide();
        }

        private void qlPXBtn_Click(object sender, EventArgs e)
        {
            GUI_QuanLyPhieuXuat newForm = new GUI_QuanLyPhieuXuat();
            newForm.Show();
            this.Hide();
        }
    }

}
