using BOOK_WEB.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BOOK_WEB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ChitietDonHang> DbSetChitietDonHang { get; set; }
        public DbSet<ChiTietGioHang> DbSetChiTietGioHang { get; set; }
        public DbSet<GiaHang> DbSetGiaHang { get;set; }
        public DbSet<DonHang> DbSetDonHang { get;  set ; }
        public DbSet<Book> books { get; set; }
        public DbSet<TheLoai>   theLoais { get; set; }  
        public DbSet<TrangThaiDonHang>  trangThaiDonHangs { get; set; } 
            
    }
}
