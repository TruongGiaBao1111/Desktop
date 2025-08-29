namespace BaiTapWindowsForm
{
    partial class frmBaiTap3
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
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnNoiChuoi = new System.Windows.Forms.Button();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiaiThua = new System.Windows.Forms.Button();
            this.lblKetQuaGiaiThua = new System.Windows.Forms.Label();
            this.lblKetQuaChuoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập tên:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(173, 29);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(100, 20);
            this.txtHo.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(173, 63);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 1;
            // 
            // btnNoiChuoi
            // 
            this.btnNoiChuoi.Location = new System.Drawing.Point(322, 47);
            this.btnNoiChuoi.Name = "btnNoiChuoi";
            this.btnNoiChuoi.Size = new System.Drawing.Size(75, 23);
            this.btnNoiChuoi.TabIndex = 2;
            this.btnNoiChuoi.Text = "Nối Chuỗi";
            this.btnNoiChuoi.UseVisualStyleBackColor = true;
            this.btnNoiChuoi.Click += new System.EventHandler(this.btnNoiChuoi_Click);
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(173, 100);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(100, 20);
            this.txtSoN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập số n:";
            // 
            // btnGiaiThua
            // 
            this.btnGiaiThua.Location = new System.Drawing.Point(322, 97);
            this.btnGiaiThua.Name = "btnGiaiThua";
            this.btnGiaiThua.Size = new System.Drawing.Size(109, 23);
            this.btnGiaiThua.TabIndex = 2;
            this.btnGiaiThua.Text = "Tính giai thừa";
            this.btnGiaiThua.UseVisualStyleBackColor = true;
            this.btnGiaiThua.Click += new System.EventHandler(this.btnGiaiThua_Click);
            // 
            // lblKetQuaGiaiThua
            // 
            this.lblKetQuaGiaiThua.AutoSize = true;
            this.lblKetQuaGiaiThua.Location = new System.Drawing.Point(319, 154);
            this.lblKetQuaGiaiThua.Name = "lblKetQuaGiaiThua";
            this.lblKetQuaGiaiThua.Size = new System.Drawing.Size(10, 13);
            this.lblKetQuaGiaiThua.TabIndex = 4;
            this.lblKetQuaGiaiThua.Text = ".";
            // 
            // lblKetQuaChuoi
            // 
            this.lblKetQuaChuoi.AutoSize = true;
            this.lblKetQuaChuoi.Location = new System.Drawing.Point(170, 154);
            this.lblKetQuaChuoi.Name = "lblKetQuaChuoi";
            this.lblKetQuaChuoi.Size = new System.Drawing.Size(10, 13);
            this.lblKetQuaChuoi.TabIndex = 4;
            this.lblKetQuaChuoi.Text = ".";
            // 
            // frmBaiTap3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 240);
            this.Controls.Add(this.lblKetQuaChuoi);
            this.Controls.Add(this.lblKetQuaGiaiThua);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.btnGiaiThua);
            this.Controls.Add(this.btnNoiChuoi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBaiTap3";
            this.Text = "Chương trình chính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnNoiChuoi;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiaiThua;
        private System.Windows.Forms.Label lblKetQuaGiaiThua;
        private System.Windows.Forms.Label lblKetQuaChuoi;
    }
}