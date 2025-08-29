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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            string s1, s2;
            XuLy.TachChuoi(txtHoTen.Text, out s1, out s2);
            lblHo.Text = s1;
            lblTen.Text = s2;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtSo1.Text);
            int n2 = int.Parse(txtSo2.Text);
            if(XuLy.ThuTu(n1,n2))
            {
                lblKetQua.Text = "Là hai số liên tiếp";
            }
            else
            {
                lblKetQua.Text = "Không là số liên tiếp";
            }
        }
    }
}
