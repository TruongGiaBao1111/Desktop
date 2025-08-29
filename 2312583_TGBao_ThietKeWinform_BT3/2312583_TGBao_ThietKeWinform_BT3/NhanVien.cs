using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ThietKeWinform_BT3
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }   
        public DateTime NgaySinh { get; set;}
        public int HeSoLuong { get; set; }
        public int HeSoPhuCap { get; set; }

        public NhanVien(string manv, string ht, DateTime ns, int hsl, int hspc)
        {
            this.MaNV = manv;
            this.HoTen = ht;
            this.NgaySinh = ns;
            this.HeSoLuong = hsl;
            this.HeSoPhuCap = hspc;
        }

        

        public decimal TinhTongLuong()
        {
            int tong;
            tong = (HeSoLuong + HeSoPhuCap) * 1150000;
            return tong;
        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaNV, HoTen, NgaySinh, HeSoLuong, HeSoPhuCap);
        }
    }
}
