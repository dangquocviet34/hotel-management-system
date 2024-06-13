using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    public class Phong
    {
        public int MaPhong { get; set; }
        public int MaLoaiPhong { get; set; }

        public Phong(int maPhong, int maLoaiPhong)
        {
            MaPhong = maPhong;
            MaLoaiPhong = maLoaiPhong;
        }

        public override string ToString()
        {
            return MaPhong.ToString();
        }
    }
}
