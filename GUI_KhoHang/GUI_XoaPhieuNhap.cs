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
    public partial class GUI_XoaPhieuNhap : Form
    {
        BUSL_PhieuNhap phieuNhap = new BUSL_PhieuNhap();
        public GUI_XoaPhieuNhap()
        {
            InitializeComponent();
        }

        private void GUI_XoaPhieuNhap_Load(object sender, EventArgs e)
        {
            dsPNView.DataSource = phieuNhap.GetPhieuNhap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_QuanLyPhieuNhap newForm = new GUI_QuanLyPhieuNhap();
            newForm.Show();
            this.Hide();
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if (phieuNhap.XoaPhieuNhap(maPNBox.Text + ""))
            {
                phieuNhap.GetPhieuNhap();
                MessageBox.Show("Xóa thành công");
            }else
            {
                MessageBox.Show("Xóa không thành công");
            }
            
            
        }
    }
}
