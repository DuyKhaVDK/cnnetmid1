using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_SP.Entities
{
    public class LichChieuPhim
    {

        public string MaChieuPhim { get; set; }

        public DateTime GioCongChieu { get; set; }

        public int SoLuong { get; set; }

        public int MaPhim { get; set; }
        public Phim Phim { get; set; }

        public int MaRap { get; set; }

        public Rap Rap { get; set; }

        public ICollection<NguoiDatVe> NguoiDatVes { get; set; }

        public LichChieuPhim()
        {
            NguoiDatVes = new HashSet<NguoiDatVe>();
        }


    }
}
