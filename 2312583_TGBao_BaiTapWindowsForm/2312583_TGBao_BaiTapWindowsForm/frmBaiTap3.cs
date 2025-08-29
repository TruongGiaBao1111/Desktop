using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class frmBaiTap3 : Form
    {
        public frmBaiTap3()
        {
            InitializeComponent();
        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string kq;
            TinhToan2.NoiChuoi(ho, ten,out kq);
        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            long kq = TinhToan2.GiaiThua(n);
            lblKetQuaGiaiThua.Text = kq.ToString();
        }
    }
}
