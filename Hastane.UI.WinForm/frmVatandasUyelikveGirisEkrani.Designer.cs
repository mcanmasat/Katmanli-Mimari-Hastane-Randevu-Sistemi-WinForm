namespace Hastane.UI.WinForm
{
    partial class frmVatandasUyelikveGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatandasUyelikveGirisEkrani));
            this.btnVatandasGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtUyeSifre = new System.Windows.Forms.TextBox();
            this.mskTxtTCKN = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUyeSoyadi = new System.Windows.Forms.TextBox();
            this.txtUyeAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUyeMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVatandasGirisYap
            // 
            this.btnVatandasGirisYap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVatandasGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVatandasGirisYap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVatandasGirisYap.Image = ((System.Drawing.Image)(resources.GetObject("btnVatandasGirisYap.Image")));
            this.btnVatandasGirisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVatandasGirisYap.Location = new System.Drawing.Point(111, 99);
            this.btnVatandasGirisYap.Name = "btnVatandasGirisYap";
            this.btnVatandasGirisYap.Size = new System.Drawing.Size(132, 48);
            this.btnVatandasGirisYap.TabIndex = 2;
            this.btnVatandasGirisYap.Text = "Sisteme Giriş";
            this.btnVatandasGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVatandasGirisYap.UseVisualStyleBackColor = false;
            this.btnVatandasGirisYap.Click += new System.EventHandler(this.btnVatandasGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(110, 68);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(133, 27);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(110, 37);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(133, 27);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVatandasGirisYap);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 193);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Ekranı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskTxtTelefon);
            this.groupBox2.Controls.Add(this.txtUyeSifre);
            this.groupBox2.Controls.Add(this.mskTxtTCKN);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnUyeOl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtUyeSoyadi);
            this.groupBox2.Controls.Add(this.txtUyeAdi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUyeMail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(324, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 330);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üyelik Ekranı";
            // 
            // mskTxtTelefon
            // 
            this.mskTxtTelefon.Location = new System.Drawing.Point(109, 118);
            this.mskTxtTelefon.Mask = "(999) 000-0000";
            this.mskTxtTelefon.Name = "mskTxtTelefon";
            this.mskTxtTelefon.Size = new System.Drawing.Size(131, 24);
            this.mskTxtTelefon.TabIndex = 3;
            // 
            // txtUyeSifre
            // 
            this.txtUyeSifre.Location = new System.Drawing.Point(109, 172);
            this.txtUyeSifre.MaxLength = 16;
            this.txtUyeSifre.Name = "txtUyeSifre";
            this.txtUyeSifre.Size = new System.Drawing.Size(131, 24);
            this.txtUyeSifre.TabIndex = 5;
            this.txtUyeSifre.TextChanged += new System.EventHandler(this.txtUyeSifre_TextChanged);
            this.txtUyeSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUyeSifre_KeyPress);
            // 
            // mskTxtTCKN
            // 
            this.mskTxtTCKN.Location = new System.Drawing.Point(109, 91);
            this.mskTxtTCKN.Mask = "00000000000";
            this.mskTxtTCKN.Name = "mskTxtTCKN";
            this.mskTxtTCKN.Size = new System.Drawing.Size(131, 24);
            this.mskTxtTCKN.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Şifre:";
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUyeOl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeOl.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeOl.Image")));
            this.btnUyeOl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeOl.Location = new System.Drawing.Point(109, 202);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(131, 100);
            this.btnUyeOl.TabIndex = 6;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "TCKN:";
            // 
            // txtUyeSoyadi
            // 
            this.txtUyeSoyadi.Location = new System.Drawing.Point(109, 64);
            this.txtUyeSoyadi.Name = "txtUyeSoyadi";
            this.txtUyeSoyadi.Size = new System.Drawing.Size(131, 24);
            this.txtUyeSoyadi.TabIndex = 1;
            // 
            // txtUyeAdi
            // 
            this.txtUyeAdi.Location = new System.Drawing.Point(109, 37);
            this.txtUyeAdi.Name = "txtUyeAdi";
            this.txtUyeAdi.Size = new System.Drawing.Size(131, 24);
            this.txtUyeAdi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ad:";
            // 
            // txtUyeMail
            // 
            this.txtUyeMail.Location = new System.Drawing.Point(109, 145);
            this.txtUyeMail.Name = "txtUyeMail";
            this.txtUyeMail.Size = new System.Drawing.Size(131, 24);
            this.txtUyeMail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // frmVatandasUyelikveGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVatandasUyelikveGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vatandaş Giriş Ekranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVatandasGirisYap;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUyeSoyadi;
        private System.Windows.Forms.TextBox txtUyeAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUyeSifre;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.MaskedTextBox mskTxtTCKN;
        private System.Windows.Forms.MaskedTextBox mskTxtTelefon;
        private System.Windows.Forms.TextBox txtUyeMail;
    }
}