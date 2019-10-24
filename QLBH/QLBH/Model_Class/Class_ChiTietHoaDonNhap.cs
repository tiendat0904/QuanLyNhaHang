using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Model_Class
{
    class Class_ChiTietHoaDonNhap
    {
        private string MaHoaDonNhap;
        private string MaNguyenLieu;
        private string SoLuong;
        private string DonGia;
        private string KhuyenMai;
        private string ThanhTien;
        public Class_ChiTietHoaDonNhap()
        {
             
        }
        public Class_ChiTietHoaDonNhap(string MaHoaDonNhap, string MaNguyenLieu, string SoLuong, string DonGia, string KhuyenMai, string ThanhTien)
        {
            this.MaHoaDonNhap = MaHoaDonNhap;
            this.MaNguyenLieu = MaNguyenLieu;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.KhuyenMai = KhuyenMai;
            this.ThanhTien = ThanhTien;
        }

        public string MaHoaDonNhap1 { get => MaHoaDonNhap; set => MaHoaDonNhap = value; }
        public string MaNguyenLieu1 { get => MaNguyenLieu; set => MaNguyenLieu = value; }
        public string SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public string DonGia1 { get => DonGia; set => DonGia = value; }
        public string KhuyenMai1 { get => KhuyenMai; set => KhuyenMai = value; }
        public string ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
    }
}
