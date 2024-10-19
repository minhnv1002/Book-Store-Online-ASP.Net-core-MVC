using BOOK_WEB.ChucNangPhanQuyen;
using Microsoft.AspNetCore.Identity;

namespace BOOK_WEB.Data
{
    public class DataSeed
    {
        public static async Task KhoiTaoDuLieuMacDinh(IServiceProvider dichVu)
        {
            var quanLiNguoiDung = dichVu.GetService<UserManager<IdentityUser>>();
            var quanLiVaiTro = dichVu.GetService<RoleManager<IdentityRole>>();
            //them 1 vai tro vao csdl
            await quanLiVaiTro.CreateAsync(new IdentityRole(PhanQuyen.Admin.ToString()));
            await quanLiVaiTro.CreateAsync(new IdentityRole(PhanQuyen.User.ToString()));

            //Tao thong tin mach dinh cho tai khoa admin:

            var quanTri = new IdentityUser
            {
                UserName = "admintest@gmail.com",
                Email = "admintest@gmail.com",
                EmailConfirmed = true
            };

            var nguoiDungTrongCSDL = await quanLiNguoiDung.FindByEmailAsync(quanTri.Email);
            // neu admin chua ton tai, them vao
            if (nguoiDungTrongCSDL is null)
            {
                //tao admin moi, pass = 12345
                await quanLiNguoiDung.CreateAsync(quanTri, "1234Minh@");
                await quanLiNguoiDung.AddToRoleAsync(quanTri, PhanQuyen.Admin.ToString());
            }
        }
    }
}
