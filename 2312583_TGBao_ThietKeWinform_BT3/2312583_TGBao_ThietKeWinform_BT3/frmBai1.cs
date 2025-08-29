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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string hoten = txtHoTen.Text;
            DateTime ns = dtpNgaySinh.Value;
            int hesl = int.Parse(txtHeSoLuong.Text);
            int hespc = int.Parse(txtHeSoPhuCap.Text);

            NhanVien nv = new NhanVien(ma, hoten, ns, hesl, hespc);
            txtKetQua.Text = nv.HienThi();
        }
    }
}
