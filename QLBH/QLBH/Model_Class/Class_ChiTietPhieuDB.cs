using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Model_Class
{
    class Class_ChiTietPhieuDB
    {
        private string MaPhieu;
        private string MaMonAn;
        private string MaLoai;
        private string SoLuong;
        private string GiamGia;
        private string ThanhTien;
        public Class_ChiTietPhieuDB()
        {

        }
        public Class_ChiTietPhieuDB(string MaPhieu, string MaMonAn, string MaLoai, string SoLuong, string GiamGia, string ThanhTien)
        {
            this.MaPhieu = MaPhieu;
            this.MaMonAn = MaMonAn;
            this.MaLoai = MaLoai;
            this.SoLuong = SoLuong;
            this.GiamGia = GiamGia;
            this.ThanhTien = ThanhTien;

        }

        public string MaPhieu1 { get => MaPhieu; set => MaPhieu = value; }
        public string MaMonAn1 { get => MaMonAn; set => MaMonAn = value; }
        public string MaLoai1 { get => MaLoai; set => MaLoai = value; }
        public string SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public string GiamGia1 { get => GiamGia; set => GiamGia = value; }
        public string ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
    }
}
