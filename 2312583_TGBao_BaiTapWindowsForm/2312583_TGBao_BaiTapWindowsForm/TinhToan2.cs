﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm
{
    internal class TinhToan2
    {
        public static void NoiChuoi(string ho, string ten,out string s)
        {
            s = ho + " " + ten;
        }

        public static long GiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }
    }
}
