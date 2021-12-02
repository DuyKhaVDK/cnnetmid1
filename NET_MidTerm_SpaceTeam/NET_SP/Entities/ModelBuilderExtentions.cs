using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NET_SP.Entities;

namespace NET_SP.Data.EF
{
    public static class DbInitializer
    {
        public static void SeedDataDefault(this ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Rap>().HasData(
                 new Rap { MaRap = 1, TenRap = "Số 1", SoChoTrong = 50, DiaChi = "250 Thành Thái" },
                 new Rap { MaRap = 2, TenRap = "Số 2", SoChoTrong = 50, DiaChi = "250 Thành Thái" },
                 new Rap { MaRap = 3, TenRap = "Số 3", SoChoTrong = 50, DiaChi = "250 Thành Thái" },
                 new Rap { MaRap = 4, TenRap = "Số 4", SoChoTrong = 50, DiaChi = "250 Thành Thái" },
                 new Rap { MaRap = 5, TenRap = "Số 1A", SoChoTrong = 50, DiaChi = "351A Lạc Long Quân Phường 5 Quận 11" },
                 new Rap { MaRap = 6, TenRap = "Số 2A", SoChoTrong = 50, DiaChi = "351A Lạc Long Quân Phường 5 Quận 11" },
                 new Rap { MaRap = 7, TenRap = "Số 3A", SoChoTrong = 50, DiaChi = "351A Lạc Long Quân Phường 5 Quận 11" },
                 new Rap { MaRap = 8, TenRap = "Số 4A", SoChoTrong = 50, DiaChi = "351A Lạc Long Quân Phường 5 Quận 11" },
                 new Rap { MaRap = 9, TenRap = "Số 1C", SoChoTrong = 50, DiaChi = "30C Công Chúa Ngọc Hân Phường 2 Quận 11" },
                 new Rap { MaRap = 10, TenRap = "Số 2C", SoChoTrong = 50, DiaChi = "30C Công Chúa Ngọc Hân Phường 2 Quận 11" },
                 new Rap { MaRap = 11, TenRap = "Số 3C", SoChoTrong = 50, DiaChi = "30C Công Chúa Ngọc Hân Phường 2 Quận 11" },
                 new Rap { MaRap = 12, TenRap = "Số 4C", SoChoTrong = 50, DiaChi = "30C Công Chúa Ngọc Hân Phường 2 Quận 11" },
                 new Rap { MaRap = 13, TenRap = "Số 1B", SoChoTrong = 50, DiaChi = "344B An Dương Vương Phường 10 Quận " },
                 new Rap { MaRap = 14, TenRap = "Số 2B", SoChoTrong = 50, DiaChi = "344B An Dương Vương Phường 10 Quận" },
                 new Rap { MaRap = 15, TenRap = "Số 3B", SoChoTrong = 50, DiaChi = "344B An Dương Vương Phường 10 Quận1" },
                 new Rap { MaRap = 16, TenRap = "Số 4B", SoChoTrong = 50, DiaChi = "344B An Dương Vương Phường 10 Quận" }


                );
            modelBuilder.Entity<Phim>().HasData(
                new Phim { MaPhim = 1, TenPhim = "Wonder Women ", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 03, 12) },
                new Phim { MaPhim = 2, TenPhim = "Iron Man ", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 03, 12) },
                new Phim { MaPhim = 3, TenPhim = "Harry Poster ", ThoiLuong = 350, NgayCongChieu = new DateTime(2020, 03, 12) },
                new Phim { MaPhim = 4, TenPhim = "Gái Gìa Lắm Chiêu ", ThoiLuong = 150, NgayCongChieu = new DateTime(2020, 05, 06) },
                new Phim { MaPhim = 5, TenPhim = "Bố Gìa ", ThoiLuong = 300, NgayCongChieu = new DateTime(2020, 07, 12) },
                new Phim { MaPhim = 6, TenPhim = "Trạng Quỷnh ", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 07, 12) },
                new Phim { MaPhim = 7, TenPhim = "Trạng Quỳnh", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 07, 12) },
                new Phim { MaPhim = 8, TenPhim = "Conan Movie 1", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 05, 06) },
                new Phim { MaPhim = 9, TenPhim = "Conan Movie 2 ", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 11, 24) },
                new Phim { MaPhim = 10, TenPhim = "Conan Movie 3", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 11, 24) },
                new Phim { MaPhim = 11, TenPhim = "Conan Movie 4", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 11, 12) },
                new Phim { MaPhim = 12, TenPhim = "Conan Movie 5", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 11, 12) },
                new Phim { MaPhim = 13, TenPhim = "Wonder Women 2 ", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 12, 12) },
                new Phim { MaPhim = 14, TenPhim = "Wonder Women 3", ThoiLuong = 250, NgayCongChieu = new DateTime(2020, 12, 12) }
                );
            modelBuilder.Entity<LichChieuPhim>().HasData(
                new LichChieuPhim { MaChieuPhim = "WonderWomen01", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 1, MaRap = 1 },
                new LichChieuPhim { MaChieuPhim = "IronMan01", GioCongChieu = new DateTime(2020, 03, 12, 7, 00, 00), SoLuong = 50, MaPhim = 2, MaRap = 1 },
                new LichChieuPhim { MaChieuPhim = "IronMan02", GioCongChieu = new DateTime(2020, 03, 12, 7, 00, 00), SoLuong = 50, MaPhim = 2, MaRap = 2 },
                new LichChieuPhim { MaChieuPhim = "HarryPoter01", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 3, MaRap = 2 },
                new LichChieuPhim { MaChieuPhim = "GaiGiaLamChieu01", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 4, MaRap = 3 },
                new LichChieuPhim { MaChieuPhim = "BoGia01", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 5, MaRap = 4 },
                new LichChieuPhim { MaChieuPhim = "TrangQuynh01", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 6, MaRap = 5 },
                new LichChieuPhim { MaChieuPhim = "TrangQuynh02", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 7, MaRap = 6 }
                //new LichChieuPhim { MaChieuPhim = "ConanMovie1", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 8, MaRap = 7 },
                //new LichChieuPhim { MaChieuPhim = "ConanMovie2", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 9, MaRap = 8 },
                //new LichChieuPhim { MaChieuPhim = "ConanMovie3", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 10, MaRap = 9 },
                //new LichChieuPhim { MaChieuPhim = "ConanMovie4", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 11, MaRap = 9 },
                //new LichChieuPhim { MaChieuPhim = "ConanMovie5", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 12, MaRap = 10 },
                //new LichChieuPhim { MaChieuPhim = "WonderWomen02", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 13, MaRap = 11 },
                //new LichChieuPhim { MaChieuPhim = "WonderWomen3", GioCongChieu = new DateTime(2020, 03, 12, 9, 00, 00), SoLuong = 50, MaPhim = 14, MaRap = 12 }
                );

            modelBuilder.Entity<NguoiDatVe>().HasData(
               new NguoiDatVe { MaNguoiDatVe = 1, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "WonderWomen01", SoLuongDat = 2 },
               new NguoiDatVe { MaNguoiDatVe = 2, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "IronMan01", SoLuongDat = 20 },
               new NguoiDatVe { MaNguoiDatVe = 3, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "IronMan02", SoLuongDat = 1 },
               new NguoiDatVe { MaNguoiDatVe = 4, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "IronMan02", SoLuongDat = 12 },
               new NguoiDatVe { MaNguoiDatVe = 5, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "IronMan01", SoLuongDat = 2 },
               new NguoiDatVe { MaNguoiDatVe = 6, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "IronMan01", SoLuongDat = 1 },
               new NguoiDatVe { MaNguoiDatVe = 7, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "IronMan01", SoLuongDat = 2 }
               //new NguoiDatVe { MaNguoiDatVe = 12, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "GaiGiaLamChieu01", SoLuongDat = 4 },
               //new NguoiDatVe { MaNguoiDatVe = 13, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "GaiGiaLamChieu01", SoLuongDat = 4 },
               //new NguoiDatVe { MaNguoiDatVe = 14, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "GaiGiaLamChieu01", SoLuongDat = 5 }
               //new NguoiDatVe { MaNguoiDatVe = 15, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "BoGia", SoLuongDat = 6 },
               //new NguoiDatVe { MaNguoiDatVe = 16, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "BoGia", SoLuongDat = 7 },
               //new NguoiDatVe { MaNguoiDatVe = 17, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "TrangQuynh", SoLuongDat = 4 },
               //new NguoiDatVe { MaNguoiDatVe = 18, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "TrangQuynh", SoLuongDat = 5 },
               //new NguoiDatVe { MaNguoiDatVe = 19, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "TrangQuynh", SoLuongDat = 2 },
               //new NguoiDatVe { MaNguoiDatVe = 20, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "ConanMovie1", SoLuongDat = 6 },
               //new NguoiDatVe { MaNguoiDatVe = 21, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "ConanMovie5", SoLuongDat = 6 },
               //new NguoiDatVe { MaNguoiDatVe = 22, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "ConanMovie4", SoLuongDat = 6 },
               //new NguoiDatVe { MaNguoiDatVe = 23, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "ConanMovie2", SoLuongDat = 2 },
               //new NguoiDatVe { MaNguoiDatVe = 24, SoDienThoai = "0344135640", DiaChi = "106 Nguyễn Tri Phương", MaChieuPhim = "WonderWomen3", SoLuongDat = 20 }
                );
        }
    }
}
