namespace Hastane.UI.WinForm
{
    partial class frmYeniRandevuAtamaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniRandevuAtamaEkrani));
            this.dtYeniRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnYeniRandevuAra = new System.Windows.Forms.Button();
            this.btnYeniRandevuOlustur = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRandevuSaatleri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtYeniRandevuTarihi
            // 
            this.dtYeniRandevuTarihi.Location = new System.Drawing.Point(77, 60);
            this.dtYeniRandevuTarihi.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtYeniRandevuTarihi.Name = "dtYeniRandevuTarihi";
            this.dtYeniRandevuTarihi.Size = new System.Drawing.Size(208, 20);
            this.dtYeniRandevuTarihi.TabIndex = 0;
            // 
            // btnYeniRandevuAra
            // 
            this.btnYeniRandevuAra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnYeniRandevuAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniRandevuAra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniRandevuAra.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniRandevuAra.Image")));
            this.btnYeniRandevuAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniRandevuAra.Location = new System.Drawing.Point(77, 106);
            this.btnYeniRandevuAra.Name = "btnYeniRandevuAra";
            this.btnYeniRandevuAra.Size = new System.Drawing.Size(157, 47);
            this.btnYeniRandevuAra.TabIndex = 3;
            this.btnYeniRandevuAra.Text = "Randevu Ara";
            this.btnYeniRandevuAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeniRandevuAra.UseVisualStyleBackColor = false;
            this.btnYeniRandevuAra.Click += new System.EventHandler(this.btnYeniRandevuAra_Click);
            // 
            // btnYeniRandevuOlustur
            // 
            this.btnYeniRandevuOlustur.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnYeniRandevuOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniRandevuOlustur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniRandevuOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniRandevuOlustur.Image")));
            this.btnYeniRandevuOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniRandevuOlustur.Location = new System.Drawing.Point(324, 318);
            this.btnYeniRandevuOlustur.Name = "btnYeniRandevuOlustur";
            this.btnYeniRandevuOlustur.Size = new System.Drawing.Size(186, 64);
            this.btnYeniRandevuOlustur.TabIndex = 10;
            this.btnYeniRandevuOlustur.Text = "Randevu Oluştur";
            this.btnYeniRandevuOlustur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeniRandevuOlustur.UseVisualStyleBackColor = false;
            this.btnYeniRandevuOlustur.Click += new System.EventHandler(this.btnYeniRandevuOlustur_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(324, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 252);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // lblRandevuSaatleri
            // 
            this.lblRandevuSaatleri.AutoSize = true;
            this.lblRandevuSaatleri.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandevuSaatleri.Location = new System.Drawing.Point(320, 19);
            this.lblRandevuSaatleri.Name = "lblRandevuSaatleri";
            this.lblRandevuSaatleri.Size = new System.Drawing.Size(120, 20);
            this.lblRandevuSaatleri.TabIndex = 8;
            this.lblRandevuSaatleri.Text = "Randevu Saatleri";
            // 
            // frmYeniRandevuAtamaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 404);
            this.Controls.Add(this.btnYeniRandevuOlustur);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblRandevuSaatleri);
            this.Controls.Add(this.btnYeniRandevuAra);
            this.Controls.Add(this.dtYeniRandevuTarihi);
            this.Name = "frmYeniRandevuAtamaEkrani";
            this.Text = "Yeni Randevu Atama Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtYeniRandevuTarihi;
        private System.Windows.Forms.Button btnYeniRandevuAra;
        private System.Windows.Forms.Button btnYeniRandevuOlustur;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblRandevuSaatleri;
    }
}