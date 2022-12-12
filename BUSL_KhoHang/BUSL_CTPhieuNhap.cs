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
    public class BUSL_CTPhieuNhap
    {
        DTAC_CTPhieuNhap cTPhieuNhap = new DTAC_CTPhieuNhap();
        public DataTable GetCTPhieuNhap(string MaPN)
        {
            return cTPhieuNhap.GetCTPhieuNhap(MaPN);
        }

        public bool ThemCTPhieuNhap(DTO_CTPhieuNhap ctpn)
        {
            return cTPhieuNhap.ThemCTPhieuNhap(ctpn);
        }
    }
}
