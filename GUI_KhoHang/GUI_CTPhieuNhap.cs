using BUSL_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class GUI_CTPhieuNhap : Form
    {
        BUSL_CTPhieuNhap cTPhieuNhap = new BUSL_CTPhieuNhap();
        public GUI_CTPhieuNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_QuanLyPhieuNhap newForm = new GUI_QuanLyPhieuNhap();
            newForm.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ShowData();
            
        }

        private void ShowData()
        {
            try
            {
                SqlConnection connec = new SqlConnection("Data Source=LAPTOP-PG6UI4J3\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True");
                string SQL = string.Format("SELECT * FROM CTPhieuNhap WHERE MaPN = MaPN", maPNBox.Text);
                SqlCommand cmd = new SqlCommand(SQL, connec);
                connec.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                ctPNView.DataSource = dt;
                connec.Close();
            }
            catch(Exception e)
            {

            }

        }
    }
}
