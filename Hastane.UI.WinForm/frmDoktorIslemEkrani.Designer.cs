namespace Hastane.UI.WinForm
{
    partial class frmDoktorIslemEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorIslemEkrani));
            this.lblDoktorUnvanAdSoyad = new System.Windows.Forms.Label();
            this.dgwGununRandevulari = new System.Windows.Forms.DataGridView();
            this.chkHastaGelmedi = new System.Windows.Forms.CheckBox();
            this.gbMuayeneIslemleri = new System.Windows.Forms.GroupBox();
            this.btnYeniRandevuOlustur = new System.Windows.Forms.Button();
            this.chkTeshisKonulamadi = new System.Windows.Forms.CheckBox();
            this.btnReceteOlustur = new System.Windows.Forms.Button();
            this.cmbTahlilTurleri = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.cmbTeshisler = new System.Windows.Forms.ComboBox();
            this.txtMuayeneNotlari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHastaAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGununRandevulari)).BeginInit();
            this.gbMuayeneIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDoktorUnvanAdSoyad
            // 
            this.lblDoktorUnvanAdSoyad.AutoSize = true;
            this.lblDoktorUnvanAdSoyad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorUnvanAdSoyad.Location = new System.Drawing.Point(12, 9);
            this.lblDoktorUnvanAdSoyad.Name = "lblDoktorUnvanAdSoyad";
            this.lblDoktorUnvanAdSoyad.Size = new System.Drawing.Size(312, 20);
            this.lblDoktorUnvanAdSoyad.TabIndex = 0;
            this.lblDoktorUnvanAdSoyad.Text = "DOKTOR İŞLEMLERİ BU EKRANDA YAPILACAK";
            // 
            // dgwGununRandevulari
            // 
            this.dgwGununRandevulari.AllowUserToAddRows = false;
            this.dgwGununRandevulari.AllowUserToDeleteRows = false;
            this.dgwGununRandevulari.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgwGununRandevulari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGununRandevulari.Location = new System.Drawing.Point(17, 37);
            this.dgwGununRandevulari.Name = "dgwGununRandevulari";
            this.dgwGununRandevulari.ReadOnly = true;
            this.dgwGununRandevulari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwGununRandevulari.Size = new System.Drawing.Size(426, 391);
            this.dgwGununRandevulari.TabIndex = 2;
            this.dgwGununRandevulari.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwGununRandevulari_RowHeaderMouseDoubleClick);
            // 
            // chkHastaGelmedi
            // 
            this.chkHastaGelmedi.AutoSize = true;
            this.chkHastaGelmedi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkHastaGelmedi.Location = new System.Drawing.Point(184, 46);
            this.chkHastaGelmedi.Name = "chkHastaGelmedi";
            this.chkHastaGelmedi.Size = new System.Drawing.Size(126, 24);
            this.chkHastaGelmedi.TabIndex = 3;
            this.chkHastaGelmedi.Text = "Hasta Gelmedi";
            this.chkHastaGelmedi.UseVisualStyleBackColor = true;
            this.chkHastaGelmedi.CheckedChanged += new System.EventHandler(this.chkHastaGelmedi_CheckedChanged);
            // 
            // gbMuayeneIslemleri
            // 
            this.gbMuayeneIslemleri.Controls.Add(this.btnYeniRandevuOlustur);
            this.gbMuayeneIslemleri.Controls.Add(this.chkTeshisKonulamadi);
            this.gbMuayeneIslemleri.Controls.Add(this.btnReceteOlustur);
            this.gbMuayeneIslemleri.Controls.Add(this.btnOnayla);
            this.gbMuayeneIslemleri.Controls.Add(this.cmbTahlilTurleri);
            this.gbMuayeneIslemleri.Controls.Add(this.label5);
            this.gbMuayeneIslemleri.Controls.Add(this.cmbTeshisler);
            this.gbMuayeneIslemleri.Controls.Add(this.txtMuayeneNotlari);
            this.gbMuayeneIslemleri.Controls.Add(this.label4);
            this.gbMuayeneIslemleri.Controls.Add(this.label2);
            this.gbMuayeneIslemleri.Controls.Add(this.txtHastaAdSoyad);
            this.gbMuayeneIslemleri.Controls.Add(this.label1);
            this.gbMuayeneIslemleri.Controls.Add(this.chkHastaGelmedi);
            this.gbMuayeneIslemleri.Location = new System.Drawing.Point(496, 37);
            this.gbMuayeneIslemleri.Name = "gbMuayeneIslemleri";
            this.gbMuayeneIslemleri.Size = new System.Drawing.Size(352, 398);
            this.gbMuayeneIslemleri.TabIndex = 4;
            this.gbMuayeneIslemleri.TabStop = false;
            this.gbMuayeneIslemleri.Text = "Muayene Ekranı";
            // 
            // btnYeniRandevuOlustur
            // 
            this.btnYeniRandevuOlustur.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnYeniRandevuOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniRandevuOlustur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniRandevuOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniRandevuOlustur.Image")));
            this.btnYeniRandevuOlustur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeniRandevuOlustur.Location = new System.Drawing.Point(21, 288);
            this.btnYeniRandevuOlustur.Name = "btnYeniRandevuOlustur";
            this.btnYeniRandevuOlustur.Size = new System.Drawing.Size(107, 97);
            this.btnYeniRandevuOlustur.TabIndex = 15;
            this.btnYeniRandevuOlustur.Text = "Yeni Randevu Oluştur";
            this.btnYeniRandevuOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeniRandevuOlustur.UseVisualStyleBackColor = false;
            this.btnYeniRandevuOlustur.Click += new System.EventHandler(this.btnYeniRandevuOlustur_Click);
            // 
            // chkTeshisKonulamadi
            // 
            this.chkTeshisKonulamadi.AutoSize = true;
            this.chkTeshisKonulamadi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTeshisKonulamadi.Location = new System.Drawing.Point(159, 105);
            this.chkTeshisKonulamadi.Name = "chkTeshisKonulamadi";
            this.chkTeshisKonulamadi.Size = new System.Drawing.Size(151, 24);
            this.chkTeshisKonulamadi.TabIndex = 14;
            this.chkTeshisKonulamadi.Text = "Teşhis Konulamadı";
            this.chkTeshisKonulamadi.UseVisualStyleBackColor = true;
            this.chkTeshisKonulamadi.CheckedChanged += new System.EventHandler(this.chkTeshisKonulamadi_CheckedChanged_1);
            // 
            // btnReceteOlustur
            // 
            this.btnReceteOlustur.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReceteOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReceteOlustur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReceteOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnReceteOlustur.Image")));
            this.btnReceteOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceteOlustur.Location = new System.Drawing.Point(136, 288);
            this.btnReceteOlustur.Name = "btnReceteOlustur";
            this.btnReceteOlustur.Size = new System.Drawing.Size(174, 44);
            this.btnReceteOlustur.TabIndex = 9;
            this.btnReceteOlustur.Text = "Reçete Oluştur";
            this.btnReceteOlustur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceteOlustur.UseVisualStyleBackColor = false;
            this.btnReceteOlustur.Click += new System.EventHandler(this.btnReceteOlustur_Click);
            // 
            // cmbTahlilTurleri
            // 
            this.cmbTahlilTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTahlilTurleri.FormattingEnabled = true;
            this.cmbTahlilTurleri.Location = new System.Drawing.Point(136, 136);
            this.cmbTahlilTurleri.Name = "cmbTahlilTurleri";
            this.cmbTahlilTurleri.Size = new System.Drawing.Size(174, 21);
            this.cmbTahlilTurleri.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tahlil:";
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnayla.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayla.Image")));
            this.btnOnayla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnayla.Location = new System.Drawing.Point(136, 341);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(174, 44);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "Muayene Onayla";
            this.btnOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // cmbTeshisler
            // 
            this.cmbTeshisler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeshisler.FormattingEnabled = true;
            this.cmbTeshisler.Location = new System.Drawing.Point(136, 77);
            this.cmbTeshisler.Name = "cmbTeshisler";
            this.cmbTeshisler.Size = new System.Drawing.Size(174, 21);
            this.cmbTeshisler.TabIndex = 1;
            // 
            // txtMuayeneNotlari
            // 
            this.txtMuayeneNotlari.Location = new System.Drawing.Point(136, 183);
            this.txtMuayeneNotlari.Multiline = true;
            this.txtMuayeneNotlari.Name = "txtMuayeneNotlari";
            this.txtMuayeneNotlari.Size = new System.Drawing.Size(174, 81);
            this.txtMuayeneNotlari.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Muayene Notları:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teşhis:";
            // 
            // txtHastaAdSoyad
            // 
            this.txtHastaAdSoyad.Location = new System.Drawing.Point(136, 19);
            this.txtHastaAdSoyad.Name = "txtHastaAdSoyad";
            this.txtHastaAdSoyad.ReadOnly = true;
            this.txtHastaAdSoyad.Size = new System.Drawing.Size(174, 20);
            this.txtHastaAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Ad Soyad:";
            // 
            // frmDoktorIslemEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 456);
            this.Controls.Add(this.gbMuayeneIslemleri);
            this.Controls.Add(this.dgwGununRandevulari);
            this.Controls.Add(this.lblDoktorUnvanAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDoktorIslemEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışma Günü";
            this.Load += new System.EventHandler(this.frmDoktorIslemEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGununRandevulari)).EndInit();
            this.gbMuayeneIslemleri.ResumeLayout(false);
            this.gbMuayeneIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwGununRandevulari;
        public System.Windows.Forms.Label lblDoktorUnvanAdSoyad;
        private System.Windows.Forms.CheckBox chkHastaGelmedi;
        private System.Windows.Forms.GroupBox gbMuayeneIslemleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMuayeneNotlari;
        private System.Windows.Forms.ComboBox cmbTeshisler;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.ComboBox cmbTahlilTurleri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReceteOlustur;
        private System.Windows.Forms.CheckBox chkTeshisKonulamadi;
        private System.Windows.Forms.Button btnYeniRandevuOlustur;
    }
}