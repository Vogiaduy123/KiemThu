using techStore_main.Models;
using techStore_main.Tests;

namespace techStore_main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo file Excel test cases
            ProgramTests.CreateTestCasesExcel();
            Console.WriteLine("Đã tạo file Excel test cases thành công!");
        }

        public SanPham NhapThongTinSanPham()
        {
            return new SanPham
            {
                MaSanPham = "SP001",
                TenSanPham = "Laptop",
                Gia = 15000000,
                SoLuong = 10
            };
        }

        public KhachHang NhapThongTinKhachHang()
        {
            return new KhachHang
            {
                MaKhachHang = "KH001",
                TenKhachHang = "Nguyen Van A",
                SoDienThoai = "0123456789",
                DiaChi = "Ha Noi"
            };
        }

        public NhanVien NhapThongTinNhanVien()
        {
            return new NhanVien
            {
                MaNhanVien = "NV001",
                TenNhanVien = "Tran Thi B",
                SoDienThoai = "0987654321",
                DiaChi = "Ho Chi Minh",
                Luong = 10000000
            };
        }

        public HoaDon NhapThongTinHoaDon()
        {
            return new HoaDon
            {
                MaHoaDon = "HD001",
                MaKhachHang = "KH001",
                MaNhanVien = "NV001",
                NgayLap = DateTime.Now,
                TongTien = 15000000
            };
        }

        public ChiTietHoaDon NhapThongTinChiTietHoaDon()
        {
            return new ChiTietHoaDon
            {
                MaHoaDon = "HD001",
                MaSanPham = "SP001",
                SoLuong = 1,
                DonGia = 15000000,
                ThanhTien = 15000000
            };
        }

        public NhaCungCap NhapThongTinNhaCungCap()
        {
            return new NhaCungCap
            {
                MaNhaCungCap = "NCC001",
                TenNhaCungCap = "Công ty A",
                SoDienThoai = "0123456789",
                DiaChi = "Ha Noi"
            };
        }

        public PhieuNhap NhapThongTinPhieuNhap()
        {
            return new PhieuNhap
            {
                MaPhieuNhap = "PN001",
                MaNhaCungCap = "NCC001",
                MaNhanVien = "NV001",
                NgayLap = DateTime.Now,
                TongTien = 15000000
            };
        }

        public ChiTietPhieuNhap NhapThongTinChiTietPhieuNhap()
        {
            return new ChiTietPhieuNhap
            {
                MaPhieuNhap = "PN001",
                MaSanPham = "SP001",
                SoLuong = 1,
                DonGia = 15000000,
                ThanhTien = 15000000
            };
        }
    }
} 