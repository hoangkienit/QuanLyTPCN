using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{

    public class DTO_PhieuXuat
    {

        private String _MaPX;
        private DateTime _NgayXuat;
        private String _MaKT;

        //Constructor
        public DTO_PhieuXuat()
        {
        }

        public DTO_PhieuXuat(string MaPX, DateTime NgayXuat, string MaKT)
        {
            this._MaPX = MaPX;
            this._NgayXuat = NgayXuat;
            this._MaKT = MaKT;

        }

        //Setter getter

        public string MaPX
        {
            get
            {
                return _MaPX;
            }

            set
            {
                _MaPX = value;
            }
        }


        public DateTime NgayXuat
        {
            get
            {
                return _NgayXuat;
            }

            set
            {
                _NgayXuat = value;
            }
        }

        public string MaKT
        {
            get
            {
                return _MaKT;
            }

            set
            {
                _MaKT = value;
            }
        }

    }
}
