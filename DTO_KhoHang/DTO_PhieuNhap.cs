using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{

    public class DTO_PhieuNhap
    {

        private String _MaPN;
        private DateTime _NgayNhap;
        private String _MaKT;

        //Constructor
        public DTO_PhieuNhap()
        {
        }

        public DTO_PhieuNhap(string MaPN, DateTime NgayNhap, string MaKT)
        {
            this._MaPN = MaPN;
            this._NgayNhap = NgayNhap;
            this._MaKT = MaKT;
        
        }

        //Setter getter

        public string MaPN
        {
            get
            {
                return _MaPN;
            }

            set
            {
                _MaPN = value;
            }
        }


        public DateTime NgayNhap
        {
            get
            {
                return _NgayNhap;
            }

            set
            {
                _NgayNhap = value;
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
