using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOOK_WEB.Models
{
    [Table("GiaHang")]
    public class GiaHang
    {
        [Key]
        public int maGioHang { get; set; }
        [Required]
        public string maNguoiDung { get; set; }
        public bool daXoa {  get; set; } = false;
        public ICollection<ChiTietGioHang> chiTietGioHangs { get; set; }
    }
}
