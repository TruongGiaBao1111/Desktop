namespace ThietKeWinform_BT4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLyThuyet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThucHang = new System.Windows.Forms.TextBox();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm lý thuyết: ";
            // 
            // txtLyThuyet
            // 
            this.txtLyThuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyThuyet.Location = new System.Drawing.Point(276, 40);
            this.txtLyThuyet.Name = "txtLyThuyet";
            this.txtLyThuyet.Size = new System.Drawing.Size(100, 26);
            this.txtLyThuyet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập điểm thực hành:";
            // 
            // txtThucHang
            // 
            this.txtThucHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThucHang.Location = new System.Drawing.Point(276, 84);
            this.txtThucHang.Name = "txtThucHang";
            this.txtThucHang.Size = new System.Drawing.Size(100, 26);
            this.txtThucHang.TabIndex = 1;
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepLoai.Location = new System.Drawing.Point(171, 147);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(99, 41);
            this.btnXepLoai.TabIndex = 2;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập điểm thực hành:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Red;
            this.lblKetQua.Location = new System.Drawing.Point(316, 245);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(13, 20);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.txtThucHang);
            this.Controls.Add(this.txtLyThuyet);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Xếp loại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLyThuyet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThucHang;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQua;
    }
}