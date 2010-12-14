using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TinTuyenDungDTO
    {
        private string _viTriTuyenDung;

        public string ViTriTuyenDung
        {
            get { return _viTriTuyenDung; }
            set { _viTriTuyenDung = value; }
        }
        private string _maSoCongViec;

        public string MaSoCongViec
        {
            get { return _maSoCongViec; }
            set { _maSoCongViec = value; }
        }
        private string _kynangCongViec;

        public string KyNangCongViec
        {
            get { return _kynangCongViec; }
            set { _kynangCongViec = value; }
        }
        private string _motaCongViec;

        public string MoTaCongViec
        {
            get { return _motaCongViec; }
            set { _motaCongViec = value; }
        }
        private int _loaiUngVien;

        public int LoaiUngVien
        {
            get { return _loaiUngVien; }
            set { _loaiUngVien = value; }
        }

        private int _nhaTuyenDung;

        public int NhanTuyenDung
        {
            get { return _nhaTuyenDung; }
            set { _nhaTuyenDung = value; }
        }

        public TinTuyenDungDTO()
        {

        }
    }
}
