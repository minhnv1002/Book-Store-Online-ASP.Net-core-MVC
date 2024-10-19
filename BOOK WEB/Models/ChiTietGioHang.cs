using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOOK_WEB.Models
{
    [Table("ChiTietGioHang")]
    public class ChiTietGioHang
    {
        [Key]
        public int maChiTietGioHang { get; set; }
        [Required]
        public int soLuong { get; set; }
        [Required]
        public int  MaGioHang { get; set; }
        [Required]
        public GiaHang gioHang { get; set; }
        public double donGia {  get; set; }
        public int maSach {  get; set; }

        public Book Book { get; set; }
    }
}
