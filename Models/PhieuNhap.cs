namespace techStore_main.Models
{
    public class PhieuNhap
    {
        public required string MaPhieuNhap { get; set; }
        public required string MaNhaCungCap { get; set; }
        public required string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
    }
} 