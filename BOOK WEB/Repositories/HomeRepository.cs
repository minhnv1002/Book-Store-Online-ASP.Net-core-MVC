using BOOK_WEB.Data;
using BOOK_WEB.Models;

namespace BOOK_WEB.Repositories
{
    public class HomeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public getBook(string keySearch = "", int theLoaiId = 0)
        {
            keySearch = keySearch.ToLower();

            var sachs = (from sach in _dbContext.sachs
                         join theLoai in _dbContext.theLoais on sach.maSach equals theLoai.maTheLoai
                         select new Sach
                         {
                             maSach = sach.maSach,
                             hinhAnh = sach.hinhAnh,
                             tenTacGia = sach.tenTacGia,
                             moTa = sach.moTa,
                             Gia = sach.Gia,
                             maTheLoai = sach.maTheLoai,
                             tenTheLoai = sach.tenTheLoai,

                         }
                         );
            return sachs;
        }

    }
}
