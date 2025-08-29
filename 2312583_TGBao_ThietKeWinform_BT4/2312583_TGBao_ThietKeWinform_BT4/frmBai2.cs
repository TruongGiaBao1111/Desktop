using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeWinform_BT4
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            int diemlyt = int.Parse(txtLyThuyet.Text); 
            int diemth = int.Parse(txtThucHang.Text);

            if(diemlyt <0 || diemlyt > 10 || diemth < 0 || diemth > 10)
            {
                MessageBox.Show("Điểm nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string xeploai;

            if(diemlyt < 5 || diemth < 5)
            {
                xeploai = "Yếu";
            }
            else
            {
                double diemtb = (diemlyt + diemth) / 2;
                if (diemtb < 7)
                    xeploai = "Trung Bình";
                else if (diemtb < 8)
                    xeploai = "Khá";
                else if (diemtb < 9)
                    xeploai = "Giỏi";
                else
                    xeploai = "Xuất sắc";
            }

            lblKetQua.Text = xeploai;
        }
    }
}
