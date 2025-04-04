using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using techStore_main;
using techStore_main.Models;

namespace UnitTest
{
    [TestFixture]
    public class ProgramTests
    {
        private Program program;

        [SetUp]
        public void Setup()
        {
            program = new Program();
        }

        [Test]
        public void TestNhapThongTinSanPham()
        {
            // Test case 1: Nhập thông tin sản phẩm hợp lệ
            var sanPham = program.NhapThongTinSanPham();
            Assert.That(sanPham, Is.Not.Null);
            Assert.That(sanPham.MaSanPham, Is.Not.Empty);
            Assert.That(sanPham.TenSanPham, Is.Not.Empty);
            Assert.That(sanPham.Gia, Is.GreaterThan(0));
            Assert.That(sanPham.SoLuong, Is.GreaterThan(0));
        }

        [Test]
        public void TestNhapThongTinKhachHang()
        {
            // Test case 1: Nhập thông tin khách hàng hợp lệ
            var khachHang = program.NhapThongTinKhachHang();
            Assert.That(khachHang, Is.Not.Null);
            Assert.That(khachHang.MaKhachHang, Is.Not.Empty);
            Assert.That(khachHang.TenKhachHang, Is.Not.Empty);
            Assert.That(khachHang.SoDienThoai, Is.Not.Empty);
            Assert.That(khachHang.DiaChi, Is.Not.Empty);
        }

        [Test]
        public void TestNhapThongTinNhanVien()
        {
            // Test case 1: Nhập thông tin nhân viên hợp lệ
            var nhanVien = program.NhapThongTinNhanVien();
            Assert.That(nhanVien, Is.Not.Null);
            Assert.That(nhanVien.MaNhanVien, Is.Not.Empty);
            Assert.That(nhanVien.TenNhanVien, Is.Not.Empty);
            Assert.That(nhanVien.SoDienThoai, Is.Not.Empty);
            Assert.That(nhanVien.DiaChi, Is.Not.Empty);
            Assert.That(nhanVien.Luong, Is.GreaterThan(0));
        }

        [Test]
        public void TestNhapThongTinHoaDon()
        {
            // Test case 1: Nhập thông tin hóa đơn hợp lệ
            var hoaDon = program.NhapThongTinHoaDon();
            Assert.That(hoaDon, Is.Not.Null);
            Assert.That(hoaDon.MaHoaDon, Is.Not.Empty);
            Assert.That(hoaDon.MaKhachHang, Is.Not.Empty);
            Assert.That(hoaDon.MaNhanVien, Is.Not.Empty);
            Assert.That(hoaDon.NgayLap, Is.Not.EqualTo(default(DateTime)));
            Assert.That(hoaDon.TongTien, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestNhapThongTinChiTietHoaDon()
        {
            // Test case 1: Nhập thông tin chi tiết hóa đơn hợp lệ
            var chiTietHoaDon = program.NhapThongTinChiTietHoaDon();
            Assert.That(chiTietHoaDon, Is.Not.Null);
            Assert.That(chiTietHoaDon.MaHoaDon, Is.Not.Empty);
            Assert.That(chiTietHoaDon.MaSanPham, Is.Not.Empty);
            Assert.That(chiTietHoaDon.SoLuong, Is.GreaterThan(0));
            Assert.That(chiTietHoaDon.DonGia, Is.GreaterThan(0));
            Assert.That(chiTietHoaDon.ThanhTien, Is.GreaterThan(0));
        }

        [Test]
        public void TestNhapThongTinNhaCungCap()
        {
            // Test case 1: Nhập thông tin nhà cung cấp hợp lệ
            var nhaCungCap = program.NhapThongTinNhaCungCap();
            Assert.That(nhaCungCap, Is.Not.Null);
            Assert.That(nhaCungCap.MaNhaCungCap, Is.Not.Empty);
            Assert.That(nhaCungCap.TenNhaCungCap, Is.Not.Empty);
            Assert.That(nhaCungCap.SoDienThoai, Is.Not.Empty);
            Assert.That(nhaCungCap.DiaChi, Is.Not.Empty);
        }

        [Test]
        public void TestNhapThongTinPhieuNhap()
        {
            // Test case 1: Nhập thông tin phiếu nhập hợp lệ
            var phieuNhap = program.NhapThongTinPhieuNhap();
            Assert.That(phieuNhap, Is.Not.Null);
            Assert.That(phieuNhap.MaPhieuNhap, Is.Not.Empty);
            Assert.That(phieuNhap.MaNhaCungCap, Is.Not.Empty);
            Assert.That(phieuNhap.MaNhanVien, Is.Not.Empty);
            Assert.That(phieuNhap.NgayLap, Is.Not.EqualTo(default(DateTime)));
            Assert.That(phieuNhap.TongTien, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestNhapThongTinChiTietPhieuNhap()
        {
            // Test case 1: Nhập thông tin chi tiết phiếu nhập hợp lệ
            var chiTietPhieuNhap = program.NhapThongTinChiTietPhieuNhap();
            Assert.That(chiTietPhieuNhap, Is.Not.Null);
            Assert.That(chiTietPhieuNhap.MaPhieuNhap, Is.Not.Empty);
            Assert.That(chiTietPhieuNhap.MaSanPham, Is.Not.Empty);
            Assert.That(chiTietPhieuNhap.SoLuong, Is.GreaterThan(0));
            Assert.That(chiTietPhieuNhap.DonGia, Is.GreaterThan(0));
            Assert.That(chiTietPhieuNhap.ThanhTien, Is.GreaterThan(0));
        }
    }
} 