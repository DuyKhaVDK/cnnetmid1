using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_SP.Entities
{
    public class NguoiDatVe
    {
        public int MaNguoiDatVe { get; set; }

        public string SoDienThoai { get; set; }

        public string DiaChi { get; set; }

        public int SoLuongDat { get; set; }

        public string MaChieuPhim { get; set; }

        public LichChieuPhim LCP { get; set; }
    }
}
