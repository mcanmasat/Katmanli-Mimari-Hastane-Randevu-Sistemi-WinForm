namespace Hastane.UI.WinForm
{
    partial class frmReceteOlusturmaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceteOlusturmaEkrani));
            this.cmbIlaclar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIlacNotlari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReceteNumarasi = new System.Windows.Forms.TextBox();
            this.btnIlacEkle = new System.Windows.Forms.Button();
            this.lstIlaclar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmbIlaclar
            // 
            this.cmbIlaclar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIlaclar.FormattingEnabled = true;
            this.cmbIlaclar.Location = new System.Drawing.Point(130, 70);
            this.cmbIlaclar.Name = "cmbIlaclar";
            this.cmbIlaclar.Size = new System.Drawing.Size(198, 21);
            this.cmbIlaclar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(0, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "İlaç Seçiniz:";
            // 
            // txtIlacNotlari
            // 
            this.txtIlacNotlari.Location = new System.Drawing.Point(130, 118);
            this.txtIlacNotlari.Multiline = true;
            this.txtIlacNotlari.Name = "txtIlacNotlari";
            this.txtIlacNotlari.Size = new System.Drawing.Size(198, 81);
            this.txtIlacNotlari.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(0, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Notlar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(0, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reçete Numarası:";
            // 
            // txtReceteNumarasi
            // 
            this.txtReceteNumarasi.Location = new System.Drawing.Point(130, 23);
            this.txtReceteNumarasi.Name = "txtReceteNumarasi";
            this.txtReceteNumarasi.ReadOnly = true;
            this.txtReceteNumarasi.Size = new System.Drawing.Size(198, 20);
            this.txtReceteNumarasi.TabIndex = 0;
            // 
            // btnIlacEkle
            // 
            this.btnIlacEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIlacEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIlacEkle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnIlacEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnIlacEkle.Image")));
            this.btnIlacEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIlacEkle.Location = new System.Drawing.Point(223, 216);
            this.btnIlacEkle.Name = "btnIlacEkle";
            this.btnIlacEkle.Size = new System.Drawing.Size(105, 46);
            this.btnIlacEkle.TabIndex = 3;
            this.btnIlacEkle.Text = "İlaç Ekle";
            this.btnIlacEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIlacEkle.UseVisualStyleBackColor = false;
            this.btnIlacEkle.Click += new System.EventHandler(this.btnIlacEkle_Click);
            // 
            // lstIlaclar
            // 
            this.lstIlaclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstIlaclar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstIlaclar.GridLines = true;
            this.lstIlaclar.Location = new System.Drawing.Point(15, 277);
            this.lstIlaclar.Name = "lstIlaclar";
            this.lstIlaclar.Size = new System.Drawing.Size(313, 129);
            this.lstIlaclar.TabIndex = 18;
            this.lstIlaclar.UseCompatibleStateImageBehavior = false;
            this.lstIlaclar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İlaç Adı";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Notlar";
            this.columnHeader2.Width = 166;
            // 
            // frmReceteOlusturmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(343, 418);
            this.Controls.Add(this.lstIlaclar);
            this.Controls.Add(this.btnIlacEkle);
            this.Controls.Add(this.txtReceteNumarasi);
            this.Controls.Add(this.txtIlacNotlari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIlaclar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReceteOlusturmaEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçete Oluşturma Ekranı";
            this.Load += new System.EventHandler(this.frmReceteOlusturmaEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIlaclar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIlacNotlari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIlacEkle;
        private System.Windows.Forms.ListView lstIlaclar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.TextBox txtReceteNumarasi;
    }
}