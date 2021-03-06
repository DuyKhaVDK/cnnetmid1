// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NET_SP.Entities;

namespace NET_SP.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NET_SP.Entities.LichChieuPhim", b =>
                {
                    b.Property<string>("MaChieuPhim")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("GioCongChieu")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaPhim")
                        .HasColumnType("int");

                    b.Property<int>("MaRap")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaChieuPhim");

                    b.HasIndex("MaPhim");

                    b.HasIndex("MaRap");

                    b.ToTable("LichChieuPhim");

                    b.HasData(
                        new
                        {
                            MaChieuPhim = "WonderWomen01",
                            GioCongChieu = new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            MaPhim = 1,
                            MaRap = 1,
                            SoLuong = 50
                        },
                        new
                        {
                            MaChieuPhim = "IronMan01",
                            GioCongChieu = new DateTime(2020, 3, 12, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            MaPhim = 2,
                            MaRap = 1,
                            SoLuong = 50
                        },
                        new
                        {
                            MaChieuPhim = "IronMan02",
                            GioCongChieu = new DateTime(2020, 3, 12, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            MaPhim = 2,
                            MaRap = 2,
                            SoLuong = 50
                        },
                        new
                        {
                            MaChieuPhim = "HarryPoter01",
                            GioCongChieu = new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            MaPhim = 3,
                            MaRap = 2,
                            SoLuong = 50
                        },
                        new
                        {
                            MaChieuPhim = "GaiGiaLamChieu01",
                            GioCongChieu = new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            MaPhim = 4,
                            MaRap = 3,
                            SoLuong = 50
                        },
                        new
                        {
                            MaChieuPhim = "BoGia01",
                            GioCongChieu = new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            MaPhim = 5,
                            MaRap = 4,
                            SoLuong = 50
                        },
                        new
                        {
                            MaChieuPhim = "TrangQuynh01",
                            GioCongChieu = new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            MaPhim = 6,
                            MaRap = 5,
                            SoLuong = 50
                        },
                        new
                        {
                            MaChieuPhim = "TrangQuynh02",
                            GioCongChieu = new DateTime(2020, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            MaPhim = 7,
                            MaRap = 6,
                            SoLuong = 50
                        });
                });

            modelBuilder.Entity("NET_SP.Entities.NguoiDatVe", b =>
                {
                    b.Property<int>("MaNguoiDatVe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaChieuPhim")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongDat")
                        .HasColumnType("int");

                    b.HasKey("MaNguoiDatVe");

                    b.HasIndex("MaChieuPhim");

                    b.ToTable("NguoiDatVe");

                    b.HasData(
                        new
                        {
                            MaNguoiDatVe = 1,
                            DiaChi = "106 Nguyễn Tri Phương",
                            MaChieuPhim = "WonderWomen01",
                            SoDienThoai = "0344135640",
                            SoLuongDat = 2
                        },
                        new
                        {
                            MaNguoiDatVe = 2,
                            DiaChi = "106 Nguyễn Tri Phương",
                            MaChieuPhim = "IronMan01",
                            SoDienThoai = "0344135640",
                            SoLuongDat = 20
                        },
                        new
                        {
                            MaNguoiDatVe = 3,
                            DiaChi = "106 Nguyễn Tri Phương",
                            MaChieuPhim = "IronMan02",
                            SoDienThoai = "0344135640",
                            SoLuongDat = 1
                        },
                        new
                        {
                            MaNguoiDatVe = 4,
                            DiaChi = "106 Nguyễn Tri Phương",
                            MaChieuPhim = "IronMan02",
                            SoDienThoai = "0344135640",
                            SoLuongDat = 12
                        },
                        new
                        {
                            MaNguoiDatVe = 5,
                            DiaChi = "106 Nguyễn Tri Phương",
                            MaChieuPhim = "IronMan01",
                            SoDienThoai = "0344135640",
                            SoLuongDat = 2
                        },
                        new
                        {
                            MaNguoiDatVe = 6,
                            DiaChi = "106 Nguyễn Tri Phương",
                            MaChieuPhim = "IronMan01",
                            SoDienThoai = "0344135640",
                            SoLuongDat = 1
                        },
                        new
                        {
                            MaNguoiDatVe = 7,
                            DiaChi = "106 Nguyễn Tri Phương",
                            MaChieuPhim = "IronMan01",
                            SoDienThoai = "0344135640",
                            SoLuongDat = 2
                        });
                });

            modelBuilder.Entity("NET_SP.Entities.Phim", b =>
                {
                    b.Property<int>("MaPhim")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NgayCongChieu")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<double>("ThoiLuong")
                        .HasColumnType("float");

                    b.HasKey("MaPhim");

                    b.ToTable("Phim");

                    b.HasData(
                        new
                        {
                            MaPhim = 1,
                            NgayCongChieu = new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Wonder Women ",
                            ThoiLuong = 250.0
                        },
                        new
                        {
                            MaPhim = 2,
                            NgayCongChieu = new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Iron Man ",
                            ThoiLuong = 250.0
                        },
                        new
                        {
                            MaPhim = 3,
                            NgayCongChieu = new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Harry Poster ",
                            ThoiLuong = 350.0
                        },
                        new
                        {
                            MaPhim = 4,
                            NgayCongChieu = new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Gái Gìa Lắm Chiêu ",
                            ThoiLuong = 150.0
                        },
                        new
                        {
                            MaPhim = 5,
                            NgayCongChieu = new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Bố Gìa ",
                            ThoiLuong = 300.0
                        },
                        new
                        {
                            MaPhim = 6,
                            NgayCongChieu = new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Trạng Quỷnh ",
                            ThoiLuong = 250.0
                        },
                        new
                        {
                            MaPhim = 7,
                            NgayCongChieu = new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Trạng Quỳnh",
                            ThoiLuong = 250.0
                        },
                        new
                        {
                            MaPhim = 8,
                            NgayCongChieu = new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Conan Movie 1",
                            ThoiLuong = 250.0
                        },
                        new
                        {
                            MaPhim = 9,
                            NgayCongChieu = new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Conan Movie 2 ",
                            ThoiLuong = 250.0
                        },
                        new
                        {
                            MaPhim = 10,
                            NgayCongChieu = new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Conan Movie 3",
                            ThoiLuong = 250.0
                        },
                        new
                        {
                            MaPhim = 11,
                            NgayCongChieu = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Conan Movie 4",
                            ThoiLuong = 250.0
                        },
                        new
                        {
                            MaPhim = 12,
                            NgayCongChieu = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Conan Movie 5",
                            ThoiLuong = 250.0
                        },
                        new
                        {
                            MaPhim = 13,
                            NgayCongChieu = new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Wonder Women 2 ",
                            ThoiLuong = 250.0
                        },
                        new
                        {
                            MaPhim = 14,
                            NgayCongChieu = new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TenPhim = "Wonder Women 3",
                            ThoiLuong = 250.0
                        });
                });

            modelBuilder.Entity("NET_SP.Entities.Rap", b =>
                {
                    b.Property<int>("MaRap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoChoTrong")
                        .HasColumnType("int");

                    b.Property<string>("TenRap")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaRap");

                    b.ToTable("Rap");

                    b.HasData(
                        new
                        {
                            MaRap = 1,
                            DiaChi = "250 Thành Thái",
                            SoChoTrong = 50,
                            TenRap = "Số 1"
                        },
                        new
                        {
                            MaRap = 2,
                            DiaChi = "250 Thành Thái",
                            SoChoTrong = 50,
                            TenRap = "Số 2"
                        },
                        new
                        {
                            MaRap = 3,
                            DiaChi = "250 Thành Thái",
                            SoChoTrong = 50,
                            TenRap = "Số 3"
                        },
                        new
                        {
                            MaRap = 4,
                            DiaChi = "250 Thành Thái",
                            SoChoTrong = 50,
                            TenRap = "Số 4"
                        },
                        new
                        {
                            MaRap = 5,
                            DiaChi = "351A Lạc Long Quân Phường 5 Quận 11",
                            SoChoTrong = 50,
                            TenRap = "Số 1A"
                        },
                        new
                        {
                            MaRap = 6,
                            DiaChi = "351A Lạc Long Quân Phường 5 Quận 11",
                            SoChoTrong = 50,
                            TenRap = "Số 2A"
                        },
                        new
                        {
                            MaRap = 7,
                            DiaChi = "351A Lạc Long Quân Phường 5 Quận 11",
                            SoChoTrong = 50,
                            TenRap = "Số 3A"
                        },
                        new
                        {
                            MaRap = 8,
                            DiaChi = "351A Lạc Long Quân Phường 5 Quận 11",
                            SoChoTrong = 50,
                            TenRap = "Số 4A"
                        },
                        new
                        {
                            MaRap = 9,
                            DiaChi = "30C Công Chúa Ngọc Hân Phường 2 Quận 11",
                            SoChoTrong = 50,
                            TenRap = "Số 1C"
                        },
                        new
                        {
                            MaRap = 10,
                            DiaChi = "30C Công Chúa Ngọc Hân Phường 2 Quận 11",
                            SoChoTrong = 50,
                            TenRap = "Số 2C"
                        },
                        new
                        {
                            MaRap = 11,
                            DiaChi = "30C Công Chúa Ngọc Hân Phường 2 Quận 11",
                            SoChoTrong = 50,
                            TenRap = "Số 3C"
                        },
                        new
                        {
                            MaRap = 12,
                            DiaChi = "30C Công Chúa Ngọc Hân Phường 2 Quận 11",
                            SoChoTrong = 50,
                            TenRap = "Số 4C"
                        },
                        new
                        {
                            MaRap = 13,
                            DiaChi = "344B An Dương Vương Phường 10 Quận ",
                            SoChoTrong = 50,
                            TenRap = "Số 1B"
                        },
                        new
                        {
                            MaRap = 14,
                            DiaChi = "344B An Dương Vương Phường 10 Quận",
                            SoChoTrong = 50,
                            TenRap = "Số 2B"
                        },
                        new
                        {
                            MaRap = 15,
                            DiaChi = "344B An Dương Vương Phường 10 Quận1",
                            SoChoTrong = 50,
                            TenRap = "Số 3B"
                        },
                        new
                        {
                            MaRap = 16,
                            DiaChi = "344B An Dương Vương Phường 10 Quận",
                            SoChoTrong = 50,
                            TenRap = "Số 4B"
                        });
                });

            modelBuilder.Entity("NET_SP.Entities.LichChieuPhim", b =>
                {
                    b.HasOne("NET_SP.Entities.Phim", "Phim")
                        .WithMany("LichChieuPhims")
                        .HasForeignKey("MaPhim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NET_SP.Entities.Rap", "Rap")
                        .WithMany("LichChieuPhims")
                        .HasForeignKey("MaRap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NET_SP.Entities.NguoiDatVe", b =>
                {
                    b.HasOne("NET_SP.Entities.LichChieuPhim", "LCP")
                        .WithMany("NguoiDatVes")
                        .HasForeignKey("MaChieuPhim");
                });
#pragma warning restore 612, 618
        }
    }
}
