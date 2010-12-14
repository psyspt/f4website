using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThongTinViecLamDTO
    {
        private string _maSoCongViec;

        public string MaSoCongViec
        {
            get { return _maSoCongViec; }
            set { _maSoCongViec = value; }
        }
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        private int _gioiTinh;

        public int GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        private int _tuoiMin;

        public int TuoiMin
        {
            get { return _tuoiMin; }
            set { _tuoiMin = value; }
        }

        private int _tuoiMax;

        public int TuoiMax
        {
            get { return _tuoiMax; }
            set { _tuoiMax = value; }
        }

        private int _soNamKinhNghiem;

        public int SoNamKinhNghiem
        {
            get { return _soNamKinhNghiem; }
            set { _soNamKinhNghiem = value; }
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

        private int _loaiCongViec;

        public int LoaiCongViec
        {
            get { return _loaiCongViec; }
            set { _loaiCongViec = value; }
        }
        private int _mucLuong;

        public int MucLuong
        {
            get { return _mucLuong; }
            set { _mucLuong = value; }
        }

        private string _phuCapKhac;

        public string PhuCapKhac
        {
            get { return _phuCapKhac; }
            set { _phuCapKhac = value; }
        }
        private DateTime _hanNopHoSo;

        public DateTime HanNopSoSo
        {
            get { return _hanNopHoSo; }
            set { _hanNopHoSo = value; }
        }
        public ThongTinViecLamDTO()
        {

        }
    }
}
