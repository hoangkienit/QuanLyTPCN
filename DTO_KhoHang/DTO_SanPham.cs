using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{ 

    public class DTO_SanPham
    {
        
        private String _MaSP;
        private String _TenSP;
        private DateTime _NgayNhap;
        private int _GiaNhap;
        private int _SoLuong;

        //Constructor
        public DTO_SanPham()
        {
        }

        public DTO_SanPham(string MaSP, string TenSP, DateTime NgayNhap, int GiaNhap, int SoLuong)
        {
            this._MaSP = MaSP;
            this._TenSP = TenSP;
            this._NgayNhap = NgayNhap;
            this._GiaNhap = GiaNhap;
            this._SoLuong = SoLuong;
        }

        //Setter getter

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

    }
}
