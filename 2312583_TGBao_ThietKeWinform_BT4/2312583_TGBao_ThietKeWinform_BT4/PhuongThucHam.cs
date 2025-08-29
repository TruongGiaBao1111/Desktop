using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeWinform_BT4
{
    internal class PhuongThucHam
    {
        public static void ChaoHoi(string hoten, bool gioitinh)
        {
            if (gioitinh == true)
                MessageBox.Show("Chào ông A");
            else
                MessageBox.Show("Chào Bà A");
        }

        public static int USCLN(int m, int n)
        {
            m = Math.Abs(m); //Lấy giá trị tuyệt đối của 2 số
            n = Math.Abs(n); 
            int temp;
            while(n != 0)
            {
                temp = n; // Lưu trữ giá trị của n
                n = m % n; 
                m = temp;
            }    
            return m;
        }
    }
}
