using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOOK_WEB.Models
{
    [Table("TheLoai")]
    public class TheLoai
    {
        [Key]
        public int maTheLoai { get; set; }
        [MaxLength(50)]
        public string? tenTheLoai {  set; get; }
        public List<Sach> sachs { get; set; }
        
    }
}
