using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi(string matb, string tentb, string nuocsx, int dongia, int sl)
        {
            this.MaThietBi = matb;
            this.TenThietBi  = tentb;
            this.NuocSanXuat = nuocsx;
            this.DonGia = dongia;
            this.SoLuong = sl;
        }

        public int ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}. {3}, {4}", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }
    }
}
