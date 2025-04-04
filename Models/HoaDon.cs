namespace techStore_main.Models
{
    public class HoaDon
    {
        public required string MaHoaDon { get; set; }
        public required string MaKhachHang { get; set; }
        public required string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
    }
} 