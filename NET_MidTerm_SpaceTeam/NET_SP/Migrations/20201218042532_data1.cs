using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NET_SP.Migrations
{
    public partial class data1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phim",
                columns: table => new
                {
                    MaPhim = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhim = table.Column<string>(maxLength: 100, nullable: false),
                    ThoiLuong = table.Column<double>(nullable: false),
                    NgayCongChieu = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phim", x => x.MaPhim);
                });

            migrationBuilder.CreateTable(
                name: "Rap",
                columns: table => new
                {
                    MaRap = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenRap = table.Column<string>(maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(nullable: true),
                    SoChoTrong = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rap", x => x.MaRap);
                });

            migrationBuilder.CreateTable(
                name: "LichChieuPhim",
                columns: table => new
                {
                    MaChieuPhim = table.Column<string>(nullable: false),
                    GioCongChieu = table.Column<DateTime>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    MaPhim = table.Column<int>(nullable: false),
                    MaRap = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichChieuPhim", x => x.MaChieuPhim);
                    table.ForeignKey(
                        name: "FK_LichChieuPhim_Phim_MaPhim",
                        column: x => x.MaPhim,
                        principalTable: "Phim",
                        principalColumn: "MaPhim",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichChieuPhim_Rap_MaRap",
                        column: x => x.MaRap,
                        principalTable: "Rap",
                        principalColumn: "MaRap",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDatVe",
                columns: table => new
                {
                    MaNguoiDatVe = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoDienThoai = table.Column<string>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true),
                    SoLuongDat = table.Column<int>(nullable: false),
                    MaChieuPhim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDatVe", x => x.MaNguoiDatVe);
                    table.ForeignKey(
                        name: "FK_NguoiDatVe_LichChieuPhim_MaChieuPhim",
                        column: x => x.MaChieuPhim,
                        principalTable: "LichChieuPhim",
                        principalColumn: "MaChieuPhim",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Phim",
                columns: new[] { "MaPhim", "NgayCongChieu", "TenPhim", "ThoiLuong" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonder Women ", 250.0 },
                    { 14, new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonder Women 3", 250.0 },
                    { 13, new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonder Women 2 ", 250.0 },
                    { 12, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conan Movie 5", 250.0 },
                    { 10, new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conan Movie 3", 250.0 },
                    { 9, new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conan Movie 2 ", 250.0 },
                    { 8, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conan Movie 1", 250.0 },
                    { 11, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conan Movie 4", 250.0 },
                    { 6, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trạng Quỷnh ", 250.0 },
                    { 5, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bố Gìa ", 300.0 },
                    { 4, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gái Gìa Lắm Chiêu ", 150.0 },
                    { 3, new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Poster ", 350.0 },
                    { 2, new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iron Man ", 250.0 },
                    { 7, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trạng Quỳnh", 250.0 }
                });

            migrationBuilder.InsertData(
                table: "Rap",
                columns: new[] { "MaRap", "DiaChi", "SoChoTrong", "TenRap" },
                values: new object[,]
                {
                    { 9, "30C Công Chúa Ngọc Hân Phường 2 Quận 11", 50, "Số 1C" },
                    { 14, "344B An Dương Vương Phường 10 Quận", 50, "Số 2B" },
                    { 13, "344B An Dương Vương Phường 10 Quận ", 50, "Số 1B" },
                    { 12, "30C Công Chúa Ngọc Hân Phường 2 Quận 11", 50, "Số 4C" },
                    { 11, "30C Công Chúa Ngọc Hân Phường 2 Quận 11", 50, "Số 3C" },
                    { 10, "30C Công Chúa Ngọc Hân Phường 2 Quận 11", 50, "Số 2C" },
                    { 8, "351A Lạc Long Quân Phường 5 Quận 11", 50, "Số 4A" },
                    { 1, "250 Thành Thái", 50, "Số 1" },
                    { 6, "351A Lạc Long Quân Phường 5 Quận 11", 50, "Số 2A" },
                    { 5, "351A Lạc Long Quân Phường 5 Quận 11", 50, "Số 1A" },
                    { 4, "250 Thành Thái", 50, "Số 4" },
                    { 3, "250 Thành Thái", 50, "Số 3" },
                    { 2, "250 Thành Thái", 50, "Số 2" },
                    { 15, "344B An Dương Vương Phường 10 Quận1", 50, "Số 3B" },
                    { 7, "351A Lạc Long Quân Phường 5 Quận 11", 50, "Số 3A" },
                    { 16, "344B An Dương Vương Phường 10 Quận", 50, "Số 4B" }
                });

            migrationBuilder.InsertData(
                table: "LichChieuPhim",
                columns: new[] { "MaChieuPhim", "GioCongChieu", "MaPhim", "MaRap", "SoLuong" },
                values: new object[,]
                {
                    { "WonderWomen01", new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 50 },
                    { "IronMan01", new DateTime(2020, 3, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 50 },
                    { "IronMan02", new DateTime(2020, 3, 12, 7, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 50 },
                    { "HarryPoter01", new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, 50 },
                    { "GaiGiaLamChieu01", new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, 50 },
                    { "BoGia01", new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, 50 },
                    { "TrangQuynh01", new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 6, 5, 50 },
                    { "TrangQuynh02", new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 7, 6, 50 }
                });

            migrationBuilder.InsertData(
                table: "NguoiDatVe",
                columns: new[] { "MaNguoiDatVe", "DiaChi", "MaChieuPhim", "SoDienThoai", "SoLuongDat" },
                values: new object[,]
                {
                    { 1, "106 Nguyễn Tri Phương", "WonderWomen01", "0344135640", 2 },
                    { 2, "106 Nguyễn Tri Phương", "IronMan01", "0344135640", 20 },
                    { 5, "106 Nguyễn Tri Phương", "IronMan01", "0344135640", 2 },
                    { 6, "106 Nguyễn Tri Phương", "IronMan01", "0344135640", 1 },
                    { 7, "106 Nguyễn Tri Phương", "IronMan01", "0344135640", 2 },
                    { 3, "106 Nguyễn Tri Phương", "IronMan02", "0344135640", 1 },
                    { 4, "106 Nguyễn Tri Phương", "IronMan02", "0344135640", 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LichChieuPhim_MaPhim",
                table: "LichChieuPhim",
                column: "MaPhim");

            migrationBuilder.CreateIndex(
                name: "IX_LichChieuPhim_MaRap",
                table: "LichChieuPhim",
                column: "MaRap");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDatVe_MaChieuPhim",
                table: "NguoiDatVe",
                column: "MaChieuPhim");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NguoiDatVe");

            migrationBuilder.DropTable(
                name: "LichChieuPhim");

            migrationBuilder.DropTable(
                name: "Phim");

            migrationBuilder.DropTable(
                name: "Rap");
        }
    }
}
