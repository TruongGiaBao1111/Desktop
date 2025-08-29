using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThietKeWinform_BT3
{
    internal class XuLy
    {
        public static void TachChuoi(string hoten, out string s1, out string s2)
        {
            hoten = hoten.Trim();
            int vt = hoten.LastIndexOf(' ');

            if(vt > 0)
            {
                s1 = hoten.Substring(0, vt); //phần họ
                s2 = hoten.Substring(vt + 1);   // phần tên
            }else
            {
                s1 = "";
                s2 = hoten;
            }
        }

        public static bool ThuTu(int n1, int n2)
        {
            return n2 == n1 + 1;
        }
    }
}
