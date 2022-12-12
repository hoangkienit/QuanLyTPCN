using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using System.Data.SqlClient;
using System.Data;
using DTAC_QuanLy;
using System.Diagnostics;

namespace DTAC_QuanLy
{
    public class DTAC_PhieuNhap : DBConnect
    {
        public DataTable GetPhieuNhap()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM PhieuNhap", _conn);
            DataTable dataPN = new DataTable();
            data.Fill(dataPN);
            return dataPN;
        }

        public bool ThemPhieuNhap(DTO_PhieuNhap pn)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO PhieuNhap(MaPN, NgayNhap, MaKT)  VALUES ('{0}', '{1}', '{2}')", pn.MaPN, pn.NgayNhap, pn.MaKT);
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

        public bool XoaPhieuNhap(string MaPN)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM PhieuNhap WHERE MaPN = MaPN", MaPN);
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
