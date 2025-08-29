namespace _2312583_TGBao_HuongDanCoBan
{
    partial class MainForm
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaochep = new System.Windows.Forms.TextBox();
            this.btnSaochep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên của bạn: ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(183, 79);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(171, 20);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(183, 122);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Xử lý";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bạn đã nhập: ";
            // 
            // txtSaochep
            // 
            this.txtSaochep.Location = new System.Drawing.Point(183, 180);
            this.txtSaochep.Name = "txtSaochep";
            this.txtSaochep.ReadOnly = true;
            this.txtSaochep.Size = new System.Drawing.Size(171, 20);
            this.txtSaochep.TabIndex = 4;
            // 
            // btnSaochep
            // 
            this.btnSaochep.Location = new System.Drawing.Point(289, 122);
            this.btnSaochep.Name = "btnSaochep";
            this.btnSaochep.Size = new System.Drawing.Size(75, 23);
            this.btnSaochep.TabIndex = 2;
            this.btnSaochep.Text = " Sao chép";
            this.btnSaochep.UseVisualStyleBackColor = true;
            this.btnSaochep.Click += new System.EventHandler(this.btnSaochep_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.txtSaochep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaochep);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Chương trình đầu tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaochep;
        private System.Windows.Forms.Button btnSaochep;
    }
}

