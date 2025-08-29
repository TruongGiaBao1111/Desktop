using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class frmBaiTap1 : Form
    {
        public frmBaiTap1()
        {
            InitializeComponent();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string nuoc = txtNuoc.Text;
            int dongia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);

            ThietBi tb = new ThietBi(ma, ten, nuoc, dongia, soLuong);
            txtKetQua.Text = tb.ToString();

        }
        
    }
}
