namespace ThietKeWinform_BT3
{
    partial class frmBai3
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnTach = new System.Windows.Forms.Button();
            this.lblHo = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(154, 54);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // btnTach
            // 
            this.btnTach.Location = new System.Drawing.Point(100, 103);
            this.btnTach.Name = "btnTach";
            this.btnTach.Size = new System.Drawing.Size(75, 23);
            this.btnTach.TabIndex = 2;
            this.btnTach.Text = "Tách";
            this.btnTach.UseVisualStyleBackColor = true;
            this.btnTach.Click += new System.EventHandler(this.btnTach_Click);
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(81, 152);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(10, 13);
            this.lblHo.TabIndex = 3;
            this.lblHo.Text = ".";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(165, 152);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(10, 13);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập số thứ 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập số thứ 2:";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(494, 54);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 20);
            this.txtSo1.TabIndex = 5;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(494, 94);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 20);
            this.txtSo2.TabIndex = 5;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(436, 142);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btnKiemTra.TabIndex = 6;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(410, 192);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(12, 17);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHo);
            this.Controls.Add(this.btnTach);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnTach;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblKetQua;
    }
}