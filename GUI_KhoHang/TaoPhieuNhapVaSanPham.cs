using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUSL_QuanLy;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_QuanLy
{
    public partial class TaoPhieuNhapVaSanPham : Form
    {
        BUSL_SanPham sanPham = new BUSL_SanPham();
        BUSL_PhieuNhap phieuNhap = new BUSL_PhieuNhap();
        BUSL_CTPhieuNhap ctPhieuNhap = new BUSL_CTPhieuNhap();

        public TaoPhieuNhapVaSanPham()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maPNBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SOLUONGValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            //create DTO san pham
            DTO_SanPham sp = new DTO_SanPham(MASPValue.Text, TENSPValue.Text, ngayNhapBox.Value, int.Parse(GIANHAPValue.Text), int.Parse(SOLUONGValue.Text));
            //Create DTO ct phieu nhap
            DTO_CTPhieuNhap ctpn = new DTO_CTPhieuNhap(maPNBox.Text, ngayNhapBox.Value, maKTBox.Text, MASPValue.Text, TENSPValue.Text, int.Parse(SOLUONGValue.Text), int.Parse(GIANHAPValue.Text));
            if (sanPham.ThemSanPham(sp))
            {
                dsspView.DataSource = sanPham.GetSanPham() ; // refresh datagridview
                if (ctPhieuNhap.ThemCTPhieuNhap(ctpn))
                {
                    MessageBox.Show("Thêm thành công");
                }

            }
            else
            {
                MessageBox.Show("Thêm ko thành công");
            }
        }

        private void taoPNBtn_Click(object sender, EventArgs e)
        {
            DTO_PhieuNhap pn = new DTO_PhieuNhap(maPNBox.Text, ngayNhapBox.Value, maKTBox.Text);
            if (phieuNhap.ThemPhieuNhap(pn))
            {
                MessageBox.Show("Thêm phiếu nhập thành công");
            }
            else
            {
                MessageBox.Show("Thêm phiếu nhập không thành công");
            }
        }

        private void TaoPhieuNhapVaSanPham_Load(object sender, EventArgs e)
        {
            dsspView.DataSource = sanPham.GetSanPham();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_QuanLyPhieuNhap newForm = new GUI_QuanLyPhieuNhap();
            newForm.Show();
            this.Hide();
        }
    }
}
