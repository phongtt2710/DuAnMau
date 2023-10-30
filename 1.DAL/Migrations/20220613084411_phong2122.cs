using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class phong2122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tableNhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VaiTro = table.Column<bool>(type: "bit", nullable: false),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tableNhanVien", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "tableHang",
                columns: table => new
                {
                    MaHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGiaBan = table.Column<float>(type: "real", nullable: false),
                    DonGiaNhap = table.Column<float>(type: "real", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tableHang", x => x.MaHang);
                    table.ForeignKey(
                        name: "FK_tableHang_tableNhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "tableNhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tableKhachHang",
                columns: table => new
                {
                    DienThoai = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TenKhach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phai = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tableKhachHang", x => x.DienThoai);
                    table.ForeignKey(
                        name: "FK_tableKhachHang_tableNhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "tableNhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tableHang_MaNV",
                table: "tableHang",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_tableKhachHang_MaNV",
                table: "tableKhachHang",
                column: "MaNV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tableHang");

            migrationBuilder.DropTable(
                name: "tableKhachHang");

            migrationBuilder.DropTable(
                name: "tableNhanVien");
        }
    }
}
