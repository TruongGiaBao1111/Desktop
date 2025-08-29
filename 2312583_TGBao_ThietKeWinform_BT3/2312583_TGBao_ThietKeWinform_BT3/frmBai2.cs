using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeWinform_BT3
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private long TinhTong(int n)
        {
            return (long)n * (n + 1) / 2;
        }

        private long TinhGiaiThua(int n)
        {
            long gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt = gt * i;
            }
            return gt;
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            //Kiểm tra và lấy giá trị N
            int n;
            if(!int.TryParse(txtNhapSoN.Text, out n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long kq = 0;
            if (rdTong.Checked)
                kq = TinhTong(n);
            if (rdGiaiThua.Checked)
                kq = TinhGiaiThua(n);

            lblKetQua.Text = kq.ToString();
        }
    }
}
