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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnChaoHoi_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text.Trim();
            bool gioiTinh = true;
            if (gioiTinh)
            {
                gioiTinh = chkNam.Checked;
            }
            else
                gioiTinh = chkNu.Checked;

            PhuongThucHam.ChaoHoi(hoten, gioiTinh);
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            int m, n;
            if(int.TryParse(txtSo1.Text.Trim(), out m) && int.TryParse(txtSo2.Text.Trim(), out n))
            {
                int ucln = PhuongThucHam.USCLN(m, n);
                lblKetQua.Text = ucln.ToString();
            }
        }
    }
}
