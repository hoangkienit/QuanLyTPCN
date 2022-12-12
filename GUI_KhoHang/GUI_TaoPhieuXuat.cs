using BUSL_QuanLy;
using DTO_QuanLy;
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
    public partial class GUI_TaoPhieuXuat : Form
    {
        BUSL_PhieuXuat phieuXuat = new BUSL_PhieuXuat();
        public GUI_TaoPhieuXuat()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTO_PhieuXuat px = new DTO_PhieuXuat(maPXBox.Text, ngayXuatBox.Value, maKT.Text);

            if (phieuXuat.ThemPhieuXuat(px))
            {
                MessageBox.Show("Thêm thành công");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI_QuanLyPhieuXuat newForm = new GUI_QuanLyPhieuXuat();
            newForm.Show();
            this.Hide();
        }
    }
}
