using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOK_WEB.Migrations
{
    /// <inheritdoc />
    public partial class capNhatKhoaNgoai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TheLoai_theLoaimaTheLoai",
                table: "Sach");

            migrationBuilder.RenameColumn(
                name: "theLoaimaTheLoai",
                table: "Sach",
                newName: "maTheLoai");

            migrationBuilder.RenameIndex(
                name: "IX_Sach_theLoaimaTheLoai",
                table: "Sach",
                newName: "IX_Sach_maTheLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TheLoai_maTheLoai",
                table: "Sach",
                column: "maTheLoai",
                principalTable: "TheLoai",
                principalColumn: "maTheLoai",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TheLoai_maTheLoai",
                table: "Sach");

            migrationBuilder.RenameColumn(
                name: "maTheLoai",
                table: "Sach",
                newName: "theLoaimaTheLoai");

            migrationBuilder.RenameIndex(
                name: "IX_Sach_maTheLoai",
                table: "Sach",
                newName: "IX_Sach_theLoaimaTheLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TheLoai_theLoaimaTheLoai",
                table: "Sach",
                column: "theLoaimaTheLoai",
                principalTable: "TheLoai",
                principalColumn: "maTheLoai",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
