namespace ThietKeWinform_BT4
{
    partial class frmBai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sản Phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Sản Xuất:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(236, 64);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(236, 98);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 1;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(236, 139);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(100, 20);
            this.dtpNgay.TabIndex = 2;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(126, 190);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết Quả:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(164, 246);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(12, 17);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại Sản Phẩm:";
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(236, 31);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(100, 20);
            this.txtLoai.TabIndex = 1;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtLoai);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoai;
    }
}