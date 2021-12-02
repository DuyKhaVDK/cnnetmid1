using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_SP.Entities
{
    public class Phim
    {
        public int MaPhim { get; set; }
        public string TenPhim { get; set; }
        public double ThoiLuong { get; set; }
        public DateTime NgayCongChieu { get; set; }


        public ICollection<LichChieuPhim> LichChieuPhims { get; set; }

        public Phim()
        {
            LichChieuPhims = new HashSet<LichChieuPhim>();
        }
    }
}
