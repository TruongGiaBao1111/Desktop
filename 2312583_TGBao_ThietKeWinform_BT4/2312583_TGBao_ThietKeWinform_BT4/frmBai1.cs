﻿using System;
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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSanPham = txtMa.Text;
            sp.TenSanPham = txtTen.Text;
            sp.LoaiSanPham = txtLoai.Text;
            sp.NgaySanXuat = dtpNgay.Value;

            lblKetQua.Text = sp.HienThi();
        }
    }
}
