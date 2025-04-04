namespace techStore_main.Models
{
    public class ChiTietHoaDon
    {
        public required string MaHoaDon { get; set; }
        public required string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
} 