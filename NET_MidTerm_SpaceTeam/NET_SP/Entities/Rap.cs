using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_SP.Entities
{
    public class Rap
    {
        public int MaRap { get; set; }

        public string TenRap { get; set; }

        public string DiaChi { get; set; }

        public int SoChoTrong { get; set; }

        public ICollection<LichChieuPhim> LichChieuPhims { get; set; }

        public Rap()
        {
            LichChieuPhims = new HashSet<LichChieuPhim>();
        }
    }
}
