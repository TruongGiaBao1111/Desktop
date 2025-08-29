namespace BaiTapWindowsForm
{
    partial class frmBaiTap2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ hai";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdChia);
            this.groupBox1.Controls.Add(this.rdNhan);
            this.groupBox1.Controls.Add(this.rdTru);
            this.groupBox1.Controls.Add(this.rdCong);
            this.groupBox1.Location = new System.Drawing.Point(166, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(187, 75);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(100, 20);
            this.txtSoThuHai.TabIndex = 2;
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(187, 36);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(100, 20);
            this.txtSoThuNhat.TabIndex = 2;
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Checked = true;
            this.rdCong.Location = new System.Drawing.Point(21, 30);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(50, 17);
            this.rdCong.TabIndex = 0;
            this.rdCong.TabStop = true;
            this.rdCong.Text = "Cộng";
            this.rdCong.UseVisualStyleBackColor = true;
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Location = new System.Drawing.Point(21, 53);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(41, 17);
            this.rdTru.TabIndex = 0;
            this.rdTru.Text = "Trừ";
            this.rdTru.UseVisualStyleBackColor = true;
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(21, 76);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(51, 17);
            this.rdNhan.TabIndex = 0;
            this.rdNhan.Text = "Nhân";
            this.rdNhan.UseVisualStyleBackColor = true;
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(21, 99);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(46, 17);
            this.rdChia.TabIndex = 0;
            this.rdChia.Text = "Chia";
            this.rdChia.UseVisualStyleBackColor = true;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(187, 278);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnXemKetQua.TabIndex = 3;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả là:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(186, 332);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(12, 17);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = ".";
            // 
            // frmBaiTap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBaiTap2";
            this.Text = "frmBaiTap2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdChia;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQua;
    }
}