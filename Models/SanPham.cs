namespace techStore_main.Models
{
    public class SanPham
    {
        public required string MaSanPham { get; set; }
        public required string TenSanPham { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
    }
} 