using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{

    public class DTO_CTPhieuNhap
    {

        private String _MaPN;
        private DateTime _NgayNhap;
        private String _MaKT;
        private String _MaSP;
        private String _TenSP;
        private int _SoLuong;
        private int _GiaNhap;

        //Constructor
        public DTO_CTPhieuNhap()
        {
        }

        public DTO_CTPhieuNhap(string MaPN, DateTime NgayNhap, string MaKT, string MaSP, string TenSP, int SoLuong, int GiaNhap)
        {
            this._MaPN = MaPN;
            this._NgayNhap = NgayNhap;
            this._MaKT = MaKT;
            this._MaSP = MaSP;
            this._TenSP = TenSP;
            this._SoLuong = SoLuong;
            this._GiaNhap = GiaNhap;

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
        public string MaSP
        {
            get
            {
                return _MaSP;
            }

            set
            {
                _MaSP = value;
            }
        }
        public string TenSP
        {
            get
            {
                return _TenSP;
            }

            set
            {
                _TenSP = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }

            set
            {
                _SoLuong = value;
            }
        }
        public int GiaNhap
        {
            get
            {
                return _GiaNhap;
            }

            set
            {
                _GiaNhap = value;
            }
        }

    }
}
