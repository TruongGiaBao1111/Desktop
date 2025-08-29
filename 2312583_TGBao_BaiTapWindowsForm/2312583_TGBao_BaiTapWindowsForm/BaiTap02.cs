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
    public partial class BaiTap02 : Form
    {
        public BaiTap02()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var form = new frmBaiTap1();
            form.ShowDialog();
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            var form = new frmBaiTap2();
            form.ShowDialog();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            var form = new frmBaiTap3();
            form.ShowDialog();  
        }
    }
}
