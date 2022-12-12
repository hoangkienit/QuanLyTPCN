using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTAC_QuanLy;
using DTO_QuanLy;

namespace BUSL_QuanLy
{
    public class BUSL_SanPham
    {
        DTAC_KhoHang dTAC_KhoHang = new DTAC_KhoHang();

        public DataTable GetSanPham()
        {
            return dTAC_KhoHang.GetSanPham();
        }

        public bool ThemSanPham(DTO_SanPham sp)
        {
            return dTAC_KhoHang.ThemSanPham(sp);
        }
    }
}
