using OfficeOpenXml;
using System;
using System.IO;
using techStore_main.Models;
using techStore_main;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techStore_main.Tests
{
    public class ProgramTests
    {
        private Program _program = new Program();

        public void Setup()
        {
            _program = new Program();
        }

        public void NhapThongTinSanPham_ReturnsCorrectSanPham()
        {
            // Arrange
            var expected = new SanPham
            {
                MaSanPham = "SP001",
                TenSanPham = "Laptop",
                Gia = 15000000,
                SoLuong = 10
            };

            // Act
            var result = _program.NhapThongTinSanPham();

            // Assert
            if (expected.MaSanPham != result.MaSanPham ||
                expected.TenSanPham != result.TenSanPham ||
                expected.Gia != result.Gia ||
                expected.SoLuong != result.SoLuong)
            {
                throw new Exception("Test case NhapThongTinSanPham_ReturnsCorrectSanPham failed");
            }
        }

        public void NhapThongTinKhachHang_ReturnsCorrectKhachHang()
        {
            // Arrange
            var expected = new KhachHang
            {
                MaKhachHang = "KH001",
                TenKhachHang = "Nguyen Van A",
                SoDienThoai = "0123456789",
                DiaChi = "Ha Noi"
            };

            // Act
            var result = _program.NhapThongTinKhachHang();

            // Assert
            if (expected.MaKhachHang != result.MaKhachHang ||
                expected.TenKhachHang != result.TenKhachHang ||
                expected.SoDienThoai != result.SoDienThoai ||
                expected.DiaChi != result.DiaChi)
            {
                throw new Exception("Test case NhapThongTinKhachHang_ReturnsCorrectKhachHang failed");
            }
        }

        public void NhapThongTinNhanVien_ReturnsCorrectNhanVien()
        {
            // Arrange
            var expected = new NhanVien
            {
                MaNhanVien = "NV001",
                TenNhanVien = "Tran Thi B",
                SoDienThoai = "0987654321",
                DiaChi = "Ho Chi Minh",
                Luong = 10000000
            };

            // Act
            var result = _program.NhapThongTinNhanVien();

            // Assert
            if (expected.MaNhanVien != result.MaNhanVien ||
                expected.TenNhanVien != result.TenNhanVien ||
                expected.SoDienThoai != result.SoDienThoai ||
                expected.DiaChi != result.DiaChi ||
                expected.Luong != result.Luong)
            {
                throw new Exception("Test case NhapThongTinNhanVien_ReturnsCorrectNhanVien failed");
            }
        }

        public void NhapThongTinHoaDon_ReturnsCorrectHoaDon()
        {
            // Arrange
            var expected = new HoaDon
            {
                MaHoaDon = "HD001",
                MaKhachHang = "KH001",
                MaNhanVien = "NV001",
                TongTien = 15000000
            };

            // Act
            var result = _program.NhapThongTinHoaDon();

            // Assert
            if (expected.MaHoaDon != result.MaHoaDon ||
                expected.MaKhachHang != result.MaKhachHang ||
                expected.MaNhanVien != result.MaNhanVien ||
                expected.TongTien != result.TongTien)
            {
                throw new Exception("Test case NhapThongTinHoaDon_ReturnsCorrectHoaDon failed");
            }
        }

        public void NhapThongTinChiTietHoaDon_ReturnsCorrectChiTietHoaDon()
        {
            // Arrange
            var expected = new ChiTietHoaDon
            {
                MaHoaDon = "HD001",
                MaSanPham = "SP001",
                SoLuong = 1,
                DonGia = 15000000,
                ThanhTien = 15000000
            };

            // Act
            var result = _program.NhapThongTinChiTietHoaDon();

            // Assert
            if (expected.MaHoaDon != result.MaHoaDon ||
                expected.MaSanPham != result.MaSanPham ||
                expected.SoLuong != result.SoLuong ||
                expected.DonGia != result.DonGia ||
                expected.ThanhTien != result.ThanhTien)
            {
                throw new Exception("Test case NhapThongTinChiTietHoaDon_ReturnsCorrectChiTietHoaDon failed");
            }
        }

        public void NhapThongTinNhaCungCap_ReturnsCorrectNhaCungCap()
        {
            // Arrange
            var expected = new NhaCungCap
            {
                MaNhaCungCap = "NCC001",
                TenNhaCungCap = "Công ty A",
                SoDienThoai = "0123456789",
                DiaChi = "Ha Noi"
            };

            // Act
            var result = _program.NhapThongTinNhaCungCap();

            // Assert
            if (expected.MaNhaCungCap != result.MaNhaCungCap ||
                expected.TenNhaCungCap != result.TenNhaCungCap ||
                expected.SoDienThoai != result.SoDienThoai ||
                expected.DiaChi != result.DiaChi)
            {
                throw new Exception("Test case NhapThongTinNhaCungCap_ReturnsCorrectNhaCungCap failed");
            }
        }

        public void NhapThongTinPhieuNhap_ReturnsCorrectPhieuNhap()
        {
            // Arrange
            var expected = new PhieuNhap
            {
                MaPhieuNhap = "PN001",
                MaNhaCungCap = "NCC001",
                MaNhanVien = "NV001",
                TongTien = 15000000
            };

            // Act
            var result = _program.NhapThongTinPhieuNhap();

            // Assert
            if (expected.MaPhieuNhap != result.MaPhieuNhap ||
                expected.MaNhaCungCap != result.MaNhaCungCap ||
                expected.MaNhanVien != result.MaNhanVien ||
                expected.TongTien != result.TongTien)
            {
                throw new Exception("Test case NhapThongTinPhieuNhap_ReturnsCorrectPhieuNhap failed");
            }
        }

        public void NhapThongTinChiTietPhieuNhap_ReturnsCorrectChiTietPhieuNhap()
        {
            // Arrange
            var expected = new ChiTietPhieuNhap
            {
                MaPhieuNhap = "PN001",
                MaSanPham = "SP001",
                SoLuong = 1,
                DonGia = 15000000,
                ThanhTien = 15000000
            };

            // Act
            var result = _program.NhapThongTinChiTietPhieuNhap();

            // Assert
            if (expected.MaPhieuNhap != result.MaPhieuNhap ||
                expected.MaSanPham != result.MaSanPham ||
                expected.SoLuong != result.SoLuong ||
                expected.DonGia != result.DonGia ||
                expected.ThanhTien != result.ThanhTien)
            {
                throw new Exception("Test case NhapThongTinChiTietPhieuNhap_ReturnsCorrectChiTietPhieuNhap failed");
            }
        }

        public static void CreateTestCasesExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("White Box Test Cases");

                // Định dạng header
                worksheet.Cells["A1"].Value = "ID";
                worksheet.Cells["B1"].Value = "Tính năng";
                worksheet.Cells["C1"].Value = "Mô tả kiểm thử";
                worksheet.Cells["D1"].Value = "Điều kiện kiểm tra";
                worksheet.Cells["E1"].Value = "Đường dẫn kiểm thử (Path)";
                worksheet.Cells["F1"].Value = "Kết quả mong đợi";
                worksheet.Cells["G1"].Value = "Kết quả thực tế";
                worksheet.Cells["H1"].Value = "Code Coverage";

                using (var range = worksheet.Cells["A1:H1"])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }

                int row = 2;

                // WB_TC001: Kiểm tra phương thức ValidateLogin()
                worksheet.Cells[$"A{row}"].Value = "WB_TC001";
                worksheet.Cells[$"B{row}"].Value = "ValidateLogin()";
                worksheet.Cells[$"C{row}"].Value = "Kiểm tra các nhánh xử lý trong phương thức ValidateLogin";
                worksheet.Cells[$"D{row}"].Value = "username = null\nusername = empty\nusername = valid\npassword = null\npassword = empty\npassword = valid";
                worksheet.Cells[$"E{row}"].Value = "1. username == null -> return false\n2. username == \"\" -> return false\n3. password == null -> return false\n4. password == \"\" -> return false\n5. Validate credentials -> return true/false";
                worksheet.Cells[$"F{row}"].Value = "Các nhánh xử lý trả về kết quả đúng theo điều kiện";
                worksheet.Cells[$"G{row}"].Value = "";
                worksheet.Cells[$"H{row}"].Value = "Branch coverage: 100%\nStatement coverage: 100%";
                row++;

                // WB_TC002: Kiểm tra phương thức ValidateProduct()
                worksheet.Cells[$"A{row}"].Value = "WB_TC002";
                worksheet.Cells[$"B{row}"].Value = "ValidateProduct()";
                worksheet.Cells[$"C{row}"].Value = "Kiểm tra validation sản phẩm với các điều kiện khác nhau";
                worksheet.Cells[$"D{row}"].Value = "product = null\nproduct.MaSP = null/empty/invalid/valid\nproduct.Gia <= 0\nproduct.SoLuong < 0";
                worksheet.Cells[$"E{row}"].Value = "1. product == null -> throw ArgumentNullException\n2. Invalid MaSP -> throw ValidationException\n3. Gia <= 0 -> throw ValidationException\n4. SoLuong < 0 -> throw ValidationException\n5. Valid product -> return true";
                worksheet.Cells[$"F{row}"].Value = "Các exception được throw đúng theo điều kiện";
                worksheet.Cells[$"G{row}"].Value = "";
                worksheet.Cells[$"H{row}"].Value = "Path coverage: 100%\nException handling: 100%";
                row++;

                // WB_TC003: Kiểm tra phương thức CalculateTotal()
                worksheet.Cells[$"A{row}"].Value = "WB_TC003";
                worksheet.Cells[$"B{row}"].Value = "CalculateTotal()";
                worksheet.Cells[$"C{row}"].Value = "Kiểm tra các nhánh tính toán tổng tiền";
                worksheet.Cells[$"D{row}"].Value = "items = null\nitems = empty\nitems = single item\nitems = multiple items";
                worksheet.Cells[$"E{row}"].Value = "1. items == null -> return 0\n2. items.Count == 0 -> return 0\n3. Single item -> calculate\n4. Multiple items -> loop and calculate";
                worksheet.Cells[$"F{row}"].Value = "Tổng tiền được tính đúng cho mọi trường hợp";
                worksheet.Cells[$"G{row}"].Value = "";
                worksheet.Cells[$"H{row}"].Value = "Loop coverage: 100%\nCondition coverage: 100%";
                row++;

                // WB_TC004: Kiểm tra phương thức UpdateInventory()
                worksheet.Cells[$"A{row}"].Value = "WB_TC004";
                worksheet.Cells[$"B{row}"].Value = "UpdateInventory()";
                worksheet.Cells[$"C{row}"].Value = "Kiểm tra các nhánh xử lý cập nhật tồn kho";
                worksheet.Cells[$"D{row}"].Value = "product = null\nquantity < 0\nquantity > currentStock\nquantity <= currentStock";
                worksheet.Cells[$"E{row}"].Value = "1. product == null -> throw ArgumentNullException\n2. quantity < 0 -> throw ArgumentException\n3. quantity > currentStock -> throw InvalidOperationException\n4. Valid update -> return true";
                worksheet.Cells[$"F{row}"].Value = "Cập nhật tồn kho đúng theo điều kiện";
                worksheet.Cells[$"G{row}"].Value = "";
                worksheet.Cells[$"H{row}"].Value = "Branch coverage: 100%\nException handling: 100%";
                row++;

                // WB_TC005: Kiểm tra phương thức SearchProducts()
                worksheet.Cells[$"A{row}"].Value = "WB_TC005";
                worksheet.Cells[$"B{row}"].Value = "SearchProducts()";
                worksheet.Cells[$"C{row}"].Value = "Kiểm tra các nhánh tìm kiếm sản phẩm";
                worksheet.Cells[$"D{row}"].Value = "keyword = null\nkeyword = empty\nkeyword = invalid\nkeyword = valid\nproducts = empty/has items";
                worksheet.Cells[$"E{row}"].Value = "1. keyword == null -> return empty\n2. keyword == \"\" -> return all\n3. products == null -> return empty\n4. Filter and return matches";
                worksheet.Cells[$"F{row}"].Value = "Kết quả tìm kiếm đúng theo điều kiện";
                worksheet.Cells[$"G{row}"].Value = "";
                worksheet.Cells[$"H{row}"].Value = "Statement coverage: 100%\nBranch coverage: 100%";
                row++;

                // WB_TC006: Kiểm tra phương thức ProcessTransaction()
                worksheet.Cells[$"A{row}"].Value = "WB_TC006";
                worksheet.Cells[$"B{row}"].Value = "ProcessTransaction()";
                worksheet.Cells[$"C{row}"].Value = "Kiểm tra xử lý giao dịch đồng thời";
                worksheet.Cells[$"D{row}"].Value = "transaction = null\ntransaction invalid\ntransaction valid\nconcurrent transactions";
                worksheet.Cells[$"E{row}"].Value = "1. Validate transaction\n2. Lock resources\n3. Process transaction\n4. Update inventory\n5. Commit/Rollback";
                worksheet.Cells[$"F{row}"].Value = "Giao dịch được xử lý đúng, không xảy ra race condition";
                worksheet.Cells[$"G{row}"].Value = "";
                worksheet.Cells[$"H{row}"].Value = "Thread safety: 100%\nTransaction handling: 100%";
                row++;

                // WB_TC007: Kiểm tra phương thức ValidateCustomer()
                worksheet.Cells[$"A{row}"].Value = "WB_TC007";
                worksheet.Cells[$"B{row}"].Value = "ValidateCustomer()";
                worksheet.Cells[$"C{row}"].Value = "Kiểm tra validation thông tin khách hàng";
                worksheet.Cells[$"D{row}"].Value = "customer = null\nphone invalid/valid\nemail invalid/valid\nother fields null/empty/valid";
                worksheet.Cells[$"E{row}"].Value = "1. Null check\n2. Phone validation\n3. Email validation\n4. Required fields check";
                worksheet.Cells[$"F{row}"].Value = "Validation đúng theo các điều kiện";
                worksheet.Cells[$"G{row}"].Value = "";
                worksheet.Cells[$"H{row}"].Value = "Path coverage: 100%\nValidation coverage: 100%";
                row++;

                // WB_TC008: Kiểm tra phương thức CalculateDiscount()
                worksheet.Cells[$"A{row}"].Value = "WB_TC008";
                worksheet.Cells[$"B{row}"].Value = "CalculateDiscount()";
                worksheet.Cells[$"C{row}"].Value = "Kiểm tra các nhánh tính giảm giá";
                worksheet.Cells[$"D{row}"].Value = "amount < 0\namount = 0\namount > 0\ndifferent discount levels";
                worksheet.Cells[$"E{row}"].Value = "1. amount < 0 -> throw ArgumentException\n2. amount == 0 -> return 0\n3. Calculate based on levels";
                worksheet.Cells[$"F{row}"].Value = "Giảm giá được tính đúng theo các mức";
                worksheet.Cells[$"G{row}"].Value = "";
                worksheet.Cells[$"H{row}"].Value = "Branch coverage: 100%\nCondition coverage: 100%";
                row++;

                // Tự động điều chỉnh độ rộng cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Lưu file
                var fileInfo = new FileInfo("WhiteBoxTestCases.xlsx");
                package.SaveAs(fileInfo);
            }
        }
    }
} 