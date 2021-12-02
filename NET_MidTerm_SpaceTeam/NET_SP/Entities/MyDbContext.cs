using Microsoft.EntityFrameworkCore;
using NET_SP.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET_SP.Entities;

namespace NET_SP.Entities
{
    public class MyDbContext :DbContext
    {
        public DbSet<Rap> Khoas { get; set; }
        public DbSet<Phim> Phims { get; set; }
        public DbSet<NguoiDatVe> NguoiDatVes { get; set; }
        public DbSet<LichChieuPhim> LichChieuPhim { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phim>(k =>
            {
                k.ToTable("Phim");
                k.HasKey(k => k.MaPhim);
                k.Property(k => k.TenPhim)
                .IsRequired(true)
                .HasMaxLength(100)
                .IsUnicode(true);
            });
            modelBuilder.Entity<Rap>(e =>
            {
                e.ToTable("Rap");
                e.HasKey(s => s.MaRap);
                e.Property(s => s.TenRap)
                .HasMaxLength(100)
                .IsRequired(true);
            });

            modelBuilder.Entity<LichChieuPhim>(kq =>
            {
                kq.ToTable("LichChieuPhim");
                kq.HasKey(kq => kq.MaChieuPhim);
                kq.HasOne(kq => kq.Rap)
               .WithMany(s => s.LichChieuPhims)
               .HasForeignKey(kq => kq.MaRap);

                kq.HasOne(kq => kq.Phim)
                .WithMany(s => s.LichChieuPhims)
                .HasForeignKey(kq => kq.MaPhim);
            });

            modelBuilder.Entity<NguoiDatVe>(kq =>
            {
                kq.ToTable("NguoiDatVe");
                
                kq.HasKey(s => s.MaNguoiDatVe);
                kq.Property(s => s.SoDienThoai)
                .IsRequired(true);
                kq.HasOne(kq => kq.LCP)
                .WithMany(s => s.NguoiDatVes)
                .HasForeignKey(kq => kq.MaChieuPhim);
            });

            modelBuilder.SeedDataDefault();

        }
        

    }
}
