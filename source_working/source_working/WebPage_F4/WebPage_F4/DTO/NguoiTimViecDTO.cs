using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NguoiTimViecDTO
    {
        private string _hoTen;

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _passWord;

        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }
        private string _eMail;

        public string EMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        private int _gioiTinh;

        public int GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        private string _dienThoai;

        public string DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }
        private int _quocGia;

        public int QuocGia
        {
            get { return _quocGia; }
            set { _quocGia = value; }
        }
        private int _tinhThanh;

        public int TinhThanh
        {
            get { return _tinhThanh; }
            set { _tinhThanh = value; }
        }
        private int _ngonNgu;

        public int NgonNgu
        {
            get { return _ngonNgu; }
            set { _ngonNgu = value; }
        }
        private string _uRLHinhAnh;

        public string URLHinhAnh
        {
            get { return _uRLHinhAnh; }
            set { _uRLHinhAnh = value; }
        }
        private int _trangThai;

        public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        public NguoiTimViecDTO()
        {
            TrangThai = 1;
            TinhThanh = 23;
            QuocGia = 1;
            NgonNgu = 1;
            URLHinhAnh = "unknown";
        }
    }
}
