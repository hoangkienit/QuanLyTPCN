using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using BUSL_QuanLy;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class GUI_QuanLyPhieuNhap : Form
    {
        private Label label1;
        private DataGridView dsPNView;
        private Button taoPN;
        private Button xoaPN;
        private Button chitietPN;
        private Button exitBtn;
        BUSL_SanPham sanPham = new BUSL_SanPham();
        BUSL_PhieuNhap phieuNhap = new BUSL_PhieuNhap();

        public GUI_QuanLyPhieuNhap()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dsPNView = new System.Windows.Forms.DataGridView();
            this.taoPN = new System.Windows.Forms.Button();
            this.xoaPN = new System.Windows.Forms.Button();
            this.chitietPN = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsPNView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phiếu nhập";
            // 
            // dsPNView
            // 
            this.dsPNView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsPNView.Location = new System.Drawing.Point(17, 50);
            this.dsPNView.Name = "dsPNView";
            this.dsPNView.RowHeadersWidth = 51;
            this.dsPNView.RowTemplate.Height = 24;
            this.dsPNView.Size = new System.Drawing.Size(525, 376);
            this.dsPNView.TabIndex = 1;
            // 
            // taoPN
            // 
            this.taoPN.Location = new System.Drawing.Point(577, 94);
            this.taoPN.Name = "taoPN";
            this.taoPN.Size = new System.Drawing.Size(158, 53);
            this.taoPN.TabIndex = 2;
            this.taoPN.Text = "Tạo phiếu nhập";
            this.taoPN.UseVisualStyleBackColor = true;
            this.taoPN.Click += new System.EventHandler(this.taoPN_Click);
            // 
            // xoaPN
            // 
            this.xoaPN.Location = new System.Drawing.Point(577, 204);
            this.xoaPN.Name = "xoaPN";
            this.xoaPN.Size = new System.Drawing.Size(158, 52);
            this.xoaPN.TabIndex = 4;
            this.xoaPN.Text = "Xóa phiếu nhập";
            this.xoaPN.UseVisualStyleBackColor = true;
            this.xoaPN.Click += new System.EventHandler(this.xoaPN_Click);
            // 
            // chitietPN
            // 
            this.chitietPN.Location = new System.Drawing.Point(577, 324);
            this.chitietPN.Name = "chitietPN";
            this.chitietPN.Size = new System.Drawing.Size(158, 44);
            this.chitietPN.TabIndex = 5;
            this.chitietPN.Text = "Chi tiết phiếu nhập";
            this.chitietPN.UseVisualStyleBackColor = true;
            this.chitietPN.Click += new System.EventHandler(this.chitietPN_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(693, 13);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(42, 41);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = ">";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // GUI_QuanLyPhieuNhap
            // 
            this.ClientSize = new System.Drawing.Size(747, 489);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.chitietPN);
            this.Controls.Add(this.xoaPN);
            this.Controls.Add(this.taoPN);
            this.Controls.Add(this.dsPNView);
            this.Controls.Add(this.label1);
            this.Name = "GUI_QuanLyPhieuNhap";
            this.Load += new System.EventHandler(this.GUI_QuanLyPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPNView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GUI_QuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            dsPNView.DataSource = phieuNhap.GetPhieuNhap();

        }

        private void taoPN_Click(object sender, EventArgs e)
        {
            TaoPhieuNhapVaSanPham newForm = new TaoPhieuNhapVaSanPham();
            newForm.Show();
            this.Hide();
        }

        private void xoaPN_Click(object sender, EventArgs e)
        {
            GUI_XoaPhieuNhap newForm = new GUI_XoaPhieuNhap();
            newForm.Show();
            this.Hide();
        }

        private void chitietPN_Click(object sender, EventArgs e)
        {
            GUI_CTPhieuNhap newForm = new GUI_CTPhieuNhap();
            newForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            GUI_TrangChu newForm = new GUI_TrangChu();
            newForm.Show();
            this.Hide();
        }
    }
}
