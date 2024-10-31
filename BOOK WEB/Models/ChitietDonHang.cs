using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOOK_WEB.Models
{
    [Table("ChitietDonHang")]
    public class ChitietDonHang
    {
        [Key]
        public int maChiTietDonHang { get; set; }
        [Required]
        public int maDonHang { get; set; }
        [Required]
        public int maSach {  get; set; }
        [Required]
        public int soLuong {  get; set; }
        [Required]
        public double donGia { get; set; }
        public Sach sach { get; set; }
        public DonHang donHang { get; set; }


    }
}
