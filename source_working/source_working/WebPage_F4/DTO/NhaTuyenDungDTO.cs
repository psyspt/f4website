using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NhaTuyenDungDTO
    {

        private string _tenCongTy;

        public string TenCongTy
        {
            get { return _tenCongTy; }
            set { _tenCongTy = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private string _dienThoai;

        public string DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }
        private int _linhVuc;

        public int LinhVuc
        {
            get { return _linhVuc; }
            set { _linhVuc = value; }
        }
        private string _tenNguoiDaiDien;

        public string TenNguoiDaiDien
        {
            get { return _tenNguoiDaiDien; }
            set { _tenNguoiDaiDien = value; }
        }
        private string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
        private string _maTKNganHang;

        public string MaTKNganHang
        {
            get { return _maTKNganHang; }
            set { _maTKNganHang = value; }
        }
        private int _trangThai;

        public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }


        public NhaTuyenDungDTO()
        {
            this.TenCongTy = "Ten Cong Ty";
            this.DiaChi = "Dia Chi";
            this.DienThoai = "Dien Thoai";
            this.Email = "EMail";
            this.LinhVuc = 2;
            this.MaTKNganHang = "MaTK";
            this.MoTa = "Mo ta";
            this.Password = "password";
            this.TenNguoiDaiDien = "Nguoi dai dien";
            this.TrangThai = 1;
        }
    }
}
