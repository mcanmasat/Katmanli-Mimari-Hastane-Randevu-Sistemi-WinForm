namespace Hastane.UI.WinForm
{
    partial class frmVatandasRandevuEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatandasRandevuEkrani));
            this.lblRandevuSaatleri = new System.Windows.Forms.Label();
            this.lblHastaAdSoyad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRandevuAra = new System.Windows.Forms.Button();
            this.dtRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.cmbDepartmanlar = new System.Windows.Forms.ComboBox();
            this.cmbHastaneler = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randevularimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRandevuSaatleri
            // 
            this.lblRandevuSaatleri.AutoSize = true;
            this.lblRandevuSaatleri.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandevuSaatleri.Location = new System.Drawing.Point(524, 46);
            this.lblRandevuSaatleri.Name = "lblRandevuSaatleri";
            this.lblRandevuSaatleri.Size = new System.Drawing.Size(120, 20);
            this.lblRandevuSaatleri.TabIndex = 0;
            this.lblRandevuSaatleri.Text = "Randevu Saatleri";
            // 
            // lblHastaAdSoyad
            // 
            this.lblHastaAdSoyad.AutoSize = true;
            this.lblHastaAdSoyad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaAdSoyad.Location = new System.Drawing.Point(18, 46);
            this.lblHastaAdSoyad.Name = "lblHastaAdSoyad";
            this.lblHastaAdSoyad.Size = new System.Drawing.Size(179, 20);
            this.lblHastaAdSoyad.TabIndex = 1;
            this.lblHastaAdSoyad.Text = "Buraya Hasta Adı Gelecek";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRandevuAra);
            this.groupBox1.Controls.Add(this.dtRandevuTarihi);
            this.groupBox1.Controls.Add(this.cmbDoktorlar);
            this.groupBox1.Controls.Add(this.cmbDepartmanlar);
            this.groupBox1.Controls.Add(this.cmbHastaneler);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.groupBox1.Location = new System.Drawing.Point(22, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 322);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu İşlemleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(25, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Doktor Seçiniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(25, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Klinik Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hastane Seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih Seçiniz:";
            // 
            // btnRandevuAra
            // 
            this.btnRandevuAra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRandevuAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandevuAra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAra.Image = ((System.Drawing.Image)(resources.GetObject("btnRandevuAra.Image")));
            this.btnRandevuAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandevuAra.Location = new System.Drawing.Point(214, 205);
            this.btnRandevuAra.Name = "btnRandevuAra";
            this.btnRandevuAra.Size = new System.Drawing.Size(157, 47);
            this.btnRandevuAra.TabIndex = 2;
            this.btnRandevuAra.Text = "Randevu Ara";
            this.btnRandevuAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRandevuAra.UseVisualStyleBackColor = false;
            this.btnRandevuAra.Click += new System.EventHandler(this.btnRandevuAra_Click);
            // 
            // dtRandevuTarihi
            // 
            this.dtRandevuTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRandevuTarihi.Location = new System.Drawing.Point(141, 51);
            this.dtRandevuTarihi.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtRandevuTarihi.Name = "dtRandevuTarihi";
            this.dtRandevuTarihi.Size = new System.Drawing.Size(325, 27);
            this.dtRandevuTarihi.TabIndex = 1;
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(140, 164);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(325, 28);
            this.cmbDoktorlar.TabIndex = 0;
            // 
            // cmbDepartmanlar
            // 
            this.cmbDepartmanlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanlar.FormattingEnabled = true;
            this.cmbDepartmanlar.Location = new System.Drawing.Point(140, 126);
            this.cmbDepartmanlar.Name = "cmbDepartmanlar";
            this.cmbDepartmanlar.Size = new System.Drawing.Size(325, 28);
            this.cmbDepartmanlar.TabIndex = 0;
            this.cmbDepartmanlar.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanlar_SelectedIndexChanged);
            // 
            // cmbHastaneler
            // 
            this.cmbHastaneler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHastaneler.FormattingEnabled = true;
            this.cmbHastaneler.Location = new System.Drawing.Point(141, 88);
            this.cmbHastaneler.Name = "cmbHastaneler";
            this.cmbHastaneler.Size = new System.Drawing.Size(325, 28);
            this.cmbHastaneler.TabIndex = 0;
            this.cmbHastaneler.SelectedIndexChanged += new System.EventHandler(this.cmbHastaneler_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(528, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 252);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRandevuOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandevuOlustur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnRandevuOlustur.Image")));
            this.btnRandevuOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandevuOlustur.Location = new System.Drawing.Point(560, 345);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(186, 64);
            this.btnRandevuOlustur.TabIndex = 7;
            this.btnRandevuOlustur.Text = "Randevu Oluştur";
            this.btnRandevuOlustur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRandevuOlustur.UseVisualStyleBackColor = false;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevularimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randevularimToolStripMenuItem
            // 
            this.randevularimToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.randevularimToolStripMenuItem.Name = "randevularimToolStripMenuItem";
            this.randevularimToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.randevularimToolStripMenuItem.Text = "Randevularım";
            this.randevularimToolStripMenuItem.Click += new System.EventHandler(this.randevularimToolStripMenuItem_Click);
            // 
            // frmVatandasRandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.btnRandevuOlustur);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHastaAdSoyad);
            this.Controls.Add(this.lblRandevuSaatleri);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVatandasRandevuEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu İşlemleri";
            this.Load += new System.EventHandler(this.frmVatandasRandevuEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandevuSaatleri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtRandevuTarihi;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.ComboBox cmbDepartmanlar;
        private System.Windows.Forms.ComboBox cmbHastaneler;
        private System.Windows.Forms.Button btnRandevuAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRandevuOlustur;
        public System.Windows.Forms.Label lblHastaAdSoyad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevularimToolStripMenuItem;
    }
}