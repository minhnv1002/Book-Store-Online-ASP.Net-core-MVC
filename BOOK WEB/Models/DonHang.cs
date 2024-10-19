using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOOK_WEB.Models
{
    [Table("DonHang")]
    public class DonHang
    {
        [Key]
        public int maDonHang { get; set; }
        [Required]
        public string maNguoiDung { get; set; }
        public DateTime ngayTaoDonHang { get; set; } = DateTime.UtcNow;
        [Required]
        public string maTrangThaiDonHang { get; set; }
        public bool daXoa { get; set; } = false;
        public TrangThaiDonHang trangThaiDonHang { get; set; }
        public List<ChitietDonHang> chitietDonHangs { get; set; }
        
    }
}
