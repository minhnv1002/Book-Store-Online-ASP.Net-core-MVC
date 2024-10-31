using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOOK_WEB.Models
{
    [Table("Sach")]
    public class Sach
    {
        [Key]
        public int maSach { set; get; }
        [MaxLength(50)]
        public string? tenSach { set; get; }
        public string? tenTacGia { set; get; }
        [Required]
        public double Gia { get; set; }

        public string? moTa {  get; set; }
        public string? hinhAnh { set; get; }
        [ForeignKey("theLoai")]
        public int maTheLoai { get; set; }
        public TheLoai theLoai { set; get; }

        public List<ChiTietGioHang> chiTietGioHangs { get; set; }
        public List<ChitietDonHang> chitietDonHangs { get; set; }

        [NotMapped]
        public string tenTheLoai { get; set; }

    }
}
