namespace Hastane.UI.WinForm
{
    partial class frmEczaciIslemEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEczaciIslemEkrani));
            this.lblEczaciAdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstIlacAdlari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTCKNReceteSorgula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstGecmisReceteIlaclari = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTxtReceteNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskTxtHastaTCKN = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEczaciAdSoyad
            // 
            this.lblEczaciAdSoyad.AutoSize = true;
            this.lblEczaciAdSoyad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEczaciAdSoyad.Location = new System.Drawing.Point(6, 19);
            this.lblEczaciAdSoyad.Name = "lblEczaciAdSoyad";
            this.lblEczaciAdSoyad.Size = new System.Drawing.Size(124, 20);
            this.lblEczaciAdSoyad.TabIndex = 0;
            this.lblEczaciAdSoyad.Text = "Hoşgeldin Mesajı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reçete Numarasını Giriniz:";
            // 
            // lstIlacAdlari
            // 
            this.lstIlacAdlari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstIlacAdlari.GridLines = true;
            this.lstIlacAdlari.Location = new System.Drawing.Point(10, 104);
            this.lstIlacAdlari.Name = "lstIlacAdlari";
            this.lstIlacAdlari.Size = new System.Drawing.Size(293, 160);
            this.lstIlacAdlari.TabIndex = 3;
            this.lstIlacAdlari.UseCompatibleStateImageBehavior = false;
            this.lstIlacAdlari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İlaç Adı";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Notlar";
            this.columnHeader2.Width = 175;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(191, 62);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(112, 36);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTCKNReceteSorgula
            // 
            this.btnTCKNReceteSorgula.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTCKNReceteSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTCKNReceteSorgula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTCKNReceteSorgula.Image = ((System.Drawing.Image)(resources.GetObject("btnTCKNReceteSorgula.Image")));
            this.btnTCKNReceteSorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTCKNReceteSorgula.Location = new System.Drawing.Point(107, 61);
            this.btnTCKNReceteSorgula.Name = "btnTCKNReceteSorgula";
            this.btnTCKNReceteSorgula.Size = new System.Drawing.Size(112, 36);
            this.btnTCKNReceteSorgula.TabIndex = 7;
            this.btnTCKNReceteSorgula.Text = "Ara";
            this.btnTCKNReceteSorgula.UseVisualStyleBackColor = false;
            this.btnTCKNReceteSorgula.Click += new System.EventHandler(this.btnTCKNReceteSorgula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "TCKN Giriniz:";
            // 
            // lstGecmisReceteIlaclari
            // 
            this.lstGecmisReceteIlaclari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstGecmisReceteIlaclari.GridLines = true;
            this.lstGecmisReceteIlaclari.Location = new System.Drawing.Point(18, 103);
            this.lstGecmisReceteIlaclari.Name = "lstGecmisReceteIlaclari";
            this.lstGecmisReceteIlaclari.Size = new System.Drawing.Size(358, 160);
            this.lstGecmisReceteIlaclari.TabIndex = 8;
            this.lstGecmisReceteIlaclari.UseCompatibleStateImageBehavior = false;
            this.lstGecmisReceteIlaclari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reçete Numarası";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İlaç Adı";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Notlar";
            this.columnHeader5.Width = 184;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskTxtReceteNumarasi);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.lstIlacAdlari);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 288);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reçete Sorgulama";
            // 
            // mskTxtReceteNumarasi
            // 
            this.mskTxtReceteNumarasi.Location = new System.Drawing.Point(194, 32);
            this.mskTxtReceteNumarasi.Mask = "00000";
            this.mskTxtReceteNumarasi.Name = "mskTxtReceteNumarasi";
            this.mskTxtReceteNumarasi.Size = new System.Drawing.Size(109, 27);
            this.mskTxtReceteNumarasi.TabIndex = 11;
            this.mskTxtReceteNumarasi.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskTxtHastaTCKN);
            this.groupBox2.Controls.Add(this.lstGecmisReceteIlaclari);
            this.groupBox2.Controls.Add(this.btnTCKNReceteSorgula);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(400, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 286);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reçete Geçmişi Ekranı";
            // 
            // mskTxtHastaTCKN
            // 
            this.mskTxtHastaTCKN.Location = new System.Drawing.Point(107, 31);
            this.mskTxtHastaTCKN.Mask = "00000000000";
            this.mskTxtHastaTCKN.Name = "mskTxtHastaTCKN";
            this.mskTxtHastaTCKN.Size = new System.Drawing.Size(112, 27);
            this.mskTxtHastaTCKN.TabIndex = 11;
            // 
            // frmEczaciIslemEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEczaciAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEczaciIslemEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçete Sorgulama Ekranı";
            this.Load += new System.EventHandler(this.frmEczaciIslemEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEczaciAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstIlacAdlari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTCKNReceteSorgula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstGecmisReceteIlaclari;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskTxtHastaTCKN;
        private System.Windows.Forms.MaskedTextBox mskTxtReceteNumarasi;
    }
}