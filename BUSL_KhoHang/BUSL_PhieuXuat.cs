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
    public class BUSL_PhieuXuat
    {
        DTAC_PhieuXuat phieuXuat = new DTAC_PhieuXuat();

        public DataTable GetPhieuXuat()
        {
            return phieuXuat.GetPhieuXuat();
        }

        public bool ThemPhieuXuat(DTO_PhieuXuat px)
        {
            return phieuXuat.ThemPhieuXuat(px);
        }

        public bool XoaPhieuXuat(string MaPX)
        {
            return phieuXuat.XoaPhieuXuat(MaPX);
        }
    }
}
