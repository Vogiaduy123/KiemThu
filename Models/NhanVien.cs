namespace techStore_main.Models
{
    public class NhanVien
    {
        public required string MaNhanVien { get; set; }
        public required string TenNhanVien { get; set; }
        public required string SoDienThoai { get; set; }
        public required string DiaChi { get; set; }
        public decimal Luong { get; set; }
    }
} 