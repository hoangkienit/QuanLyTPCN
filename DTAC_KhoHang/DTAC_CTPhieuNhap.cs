using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QuanLy;
using System.Data;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace DTAC_QuanLy
{
    public class DTAC_CTPhieuNhap : DBConnect
    {
        public DataTable GetCTPhieuNhap(string MaPN)
        {
                
                string SQL = string.Format("DELETE FROM PhieuNhap WHERE MaPN = MaPN", MaPN);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataCTPN = new DataTable();
                adapter.Fill(dataCTPN);
                return dataCTPN;
                //Wrong code
        }
        public bool ThemCTPhieuNhap(DTO_CTPhieuNhap ctpn)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO CTPhieuNhap(MaPN, NgayNhap, MaKT, MaSP, TenSP, SoLuong, GiaNhap)  VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", ctpn.MaPN, ctpn.NgayNhap, ctpn.MaKT, ctpn.MaSP, ctpn.TenSP, ctpn.SoLuong, ctpn.GiaNhap);
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                Debug.Print("Error" + e);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
