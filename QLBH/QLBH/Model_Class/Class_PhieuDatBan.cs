using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Model_Class
{
    class Class_PhieuDatBan
    {
        private string MaPhieu;
        private string MaKhach;
        private string MaNhanVien;
        private string NgayDat;
        private string NgayDung;
        private string TongTien;
        public Class_PhieuDatBan()
        {

        }
        public Class_PhieuDatBan(string MaPhieu, string MaKhach, string MaNhanVien, string NgayDat, string NgayDung, string TongTien)
        {
            this.MaPhieu = MaPhieu;
            this.MaKhach = MaKhach;
            this.MaNhanVien = MaNhanVien;
            this.NgayDat = NgayDat;
            this.NgayDung = NgayDung;
            this.TongTien = TongTien;
        }

        public string MaPhieu1 { get => MaPhieu; set => MaPhieu = value; }
        public string MaKhach1 { get => MaKhach; set => MaKhach = value; }
        public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
        public string NgayDat1 { get => NgayDat; set => NgayDat = value; }
        public string NgayDung1 { get => NgayDung; set => NgayDung = value; }
        public string TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
