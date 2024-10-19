using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOOK_WEB.Models
{
    [Table("TrangThaiDonHang")]
    public class TrangThaiDonHang
    {
        [Key]
        public int maTrangThaiDonHang { get; set; }
        [MaxLength(50)]
        [Required]
        public string? tenTrangThaiDonHang { get; set; }
    }
}
