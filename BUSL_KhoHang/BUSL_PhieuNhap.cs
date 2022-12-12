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
    public class BUSL_PhieuNhap
    {
        DTAC_PhieuNhap phieuNhap = new DTAC_PhieuNhap();

        public DataTable GetPhieuNhap()
        {
            return phieuNhap.GetPhieuNhap();
        }

        public bool ThemPhieuNhap(DTO_PhieuNhap pn)
        {
            return phieuNhap.ThemPhieuNhap(pn);
        }

        public bool XoaPhieuNhap(string MaPN)
        {
            return phieuNhap.XoaPhieuNhap(MaPN);
        }
    }
}
