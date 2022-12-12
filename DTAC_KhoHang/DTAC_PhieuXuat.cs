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
    public class DTAC_PhieuXuat : DBConnect
    {
        public DataTable GetPhieuXuat()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM PhieuXuat", _conn);
            DataTable dataPX = new DataTable();
            data.Fill(dataPX);
            return dataPX;
        }

        public bool ThemPhieuXuat(DTO_PhieuXuat px)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO PhieuXuat(MaPX, NgayXuat, MaKT)  VALUES ('{0}', '{1}', '{2}')", px.MaPX, px.NgayXuat, px.MaKT);
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

        public bool XoaPhieuXuat(string MaPX)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM PhieuXuat WHERE MaPX = MaPX", MaPX);
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
