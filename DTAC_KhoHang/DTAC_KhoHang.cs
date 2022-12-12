using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QuanLy;
using System.Data;
using System.Diagnostics;

namespace DTAC_QuanLy
{
    public class DTAC_KhoHang : DBConnect
    {

        public DataTable GetSanPham()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM SanPham", _conn);
            DataTable dataSP = new DataTable();
            data.Fill(dataSP);
            return dataSP;
        }

        public bool ThemSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO SanPham(MaSP, TenSP, NgayNhap, GiaNhap, SoLuong)  VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", sp.MaSP, sp.TenSP, sp.NgayNhap, sp.GiaNhap, sp.SoLuong);
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

        public bool BanSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE THANHVIEN SET TV_NAME = '{0}', TV_PHONE = '{1}', TV_EMAIL = '{2}' WHERE TV_ID = {3}", sp.MaSP, sp.TenSP, sp.NgayNhap, sp.GiaNhap);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
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
