namespace _2312583_TGBao_ThietKeForm
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnBohang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 334);
            this.panel1.TabIndex = 0;
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(239, 94);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(115, 25);
            this.btnChonHang.TabIndex = 2;
            this.btnChonHang.Text = "Chọn hàng >";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB kingmax"});
            this.listBox1.Location = new System.Drawing.Point(28, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 116);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hàng hoá :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.btnBohang);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblSoTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Location = new System.Drawing.Point(389, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 334);
            this.panel2.TabIndex = 1;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(187, 223);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(115, 25);
            this.btnTinhTien.TabIndex = 2;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnBohang
            // 
            this.btnBohang.Location = new System.Drawing.Point(19, 94);
            this.btnBohang.Name = "btnBohang";
            this.btnBohang.Size = new System.Drawing.Size(115, 25);
            this.btnBohang.TabIndex = 2;
            this.btnBohang.Text = "< Bỏ hàng";
            this.btnBohang.UseVisualStyleBackColor = true;
            this.btnBohang.Click += new System.EventHandler(this.btnBohang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền thanh toán:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(140, 77);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(213, 116);
            this.listBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Các mặt hàng khách mua :";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSoTien.Location = new System.Drawing.Point(229, 293);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(19, 20);
            this.lblSoTien.TabIndex = 0;
            this.lblSoTien.Text = "0";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnBohang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoTien;
    }
}