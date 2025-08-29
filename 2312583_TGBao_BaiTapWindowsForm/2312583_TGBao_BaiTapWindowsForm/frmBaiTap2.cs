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
    public partial class frmBaiTap2 : Form
    {
        public frmBaiTap2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSoThuNhat.Text);
            int so2 = int.Parse(txtSoThuHai.Text);
            int kq = 0;

            if (rdCong.Checked)
                kq = so1 += so2;
            if(rdTru.Checked)
                kq = so1 -= so2;
            if (rdNhan.Checked)
                kq = so1 *= so2;
            if(rdChia.Checked)
                kq = so1 /= so2;

            lblKetQua.Text = kq.ToString();
                
        }
    }
}
