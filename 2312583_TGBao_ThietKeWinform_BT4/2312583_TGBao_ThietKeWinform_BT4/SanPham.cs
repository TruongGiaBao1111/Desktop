﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeWinform_BT4
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }

        public DateTime NgaySanXuat { get; set; }

        public SanPham()
        {

        }

        //Phương thức lấy năm hết hạn
        public int NamHetHan()
        {
            return NgaySanXuat.AddYears(3).Year;
        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}", MaSanPham, TenSanPham, LoaiSanPham, NgaySanXuat);
        }
    }
}
