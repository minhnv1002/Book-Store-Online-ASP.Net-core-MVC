using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOK_WEB.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThemBangDuLieu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiaHang",
                columns: table => new
                {
                    maGioHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maNguoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    daXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaHang", x => x.maGioHang);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    maTheLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTheLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.maTheLoai);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiDonHang",
                columns: table => new
                {
                    maTrangThaiDonHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTrangThaiDonHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiDonHang", x => x.maTrangThaiDonHang);
                });

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    maSach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenSach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tenTacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    hinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    theLoaimaTheLoai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.maSach);
                    table.ForeignKey(
                        name: "FK_Sach_TheLoai_theLoaimaTheLoai",
                        column: x => x.theLoaimaTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "maTheLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    maDonHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maNguoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngayTaoDonHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maTrangThaiDonHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    daXoa = table.Column<bool>(type: "bit", nullable: false),
                    trangThaiDonHangmaTrangThaiDonHang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.maDonHang);
                    table.ForeignKey(
                        name: "FK_DonHang_TrangThaiDonHang_trangThaiDonHangmaTrangThaiDonHang",
                        column: x => x.trangThaiDonHangmaTrangThaiDonHang,
                        principalTable: "TrangThaiDonHang",
                        principalColumn: "maTrangThaiDonHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietGioHang",
                columns: table => new
                {
                    maChiTietGioHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soLuong = table.Column<int>(type: "int", nullable: false),
                    MaGioHang = table.Column<int>(type: "int", nullable: false),
                    gioHangmaGioHang = table.Column<int>(type: "int", nullable: false),
                    donGia = table.Column<double>(type: "float", nullable: false),
                    maSach = table.Column<int>(type: "int", nullable: false),
                    BookmaSach = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGioHang", x => x.maChiTietGioHang);
                    table.ForeignKey(
                        name: "FK_ChiTietGioHang_GiaHang_gioHangmaGioHang",
                        column: x => x.gioHangmaGioHang,
                        principalTable: "GiaHang",
                        principalColumn: "maGioHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietGioHang_Sach_BookmaSach",
                        column: x => x.BookmaSach,
                        principalTable: "Sach",
                        principalColumn: "maSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChitietDonHang",
                columns: table => new
                {
                    maChiTietDonHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maDonHang = table.Column<int>(type: "int", nullable: false),
                    maSach = table.Column<int>(type: "int", nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: false),
                    donGia = table.Column<double>(type: "float", nullable: false),
                    bookmaSach = table.Column<int>(type: "int", nullable: false),
                    donHangmaDonHang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChitietDonHang", x => x.maChiTietDonHang);
                    table.ForeignKey(
                        name: "FK_ChitietDonHang_DonHang_donHangmaDonHang",
                        column: x => x.donHangmaDonHang,
                        principalTable: "DonHang",
                        principalColumn: "maDonHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChitietDonHang_Sach_bookmaSach",
                        column: x => x.bookmaSach,
                        principalTable: "Sach",
                        principalColumn: "maSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChitietDonHang_bookmaSach",
                table: "ChitietDonHang",
                column: "bookmaSach");

            migrationBuilder.CreateIndex(
                name: "IX_ChitietDonHang_donHangmaDonHang",
                table: "ChitietDonHang",
                column: "donHangmaDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_BookmaSach",
                table: "ChiTietGioHang",
                column: "BookmaSach");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_gioHangmaGioHang",
                table: "ChiTietGioHang",
                column: "gioHangmaGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_trangThaiDonHangmaTrangThaiDonHang",
                table: "DonHang",
                column: "trangThaiDonHangmaTrangThaiDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_theLoaimaTheLoai",
                table: "Sach",
                column: "theLoaimaTheLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChitietDonHang");

            migrationBuilder.DropTable(
                name: "ChiTietGioHang");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "GiaHang");

            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "TrangThaiDonHang");

            migrationBuilder.DropTable(
                name: "TheLoai");
        }
    }
}
