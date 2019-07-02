namespace Hastane.UI.WinForm
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btnVatandasGirisYap = new System.Windows.Forms.Button();
            this.btnEczaciGirisYap = new System.Windows.Forms.Button();
            this.btnDoktorGirisYap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVatandasGirisYap
            // 
            this.btnVatandasGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVatandasGirisYap.BackgroundImage")));
            this.btnVatandasGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVatandasGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVatandasGirisYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVatandasGirisYap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVatandasGirisYap.Location = new System.Drawing.Point(354, 173);
            this.btnVatandasGirisYap.Name = "btnVatandasGirisYap";
            this.btnVatandasGirisYap.Size = new System.Drawing.Size(138, 153);
            this.btnVatandasGirisYap.TabIndex = 2;
            this.btnVatandasGirisYap.Text = "Vatandaş Girişi";
            this.btnVatandasGirisYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVatandasGirisYap.UseVisualStyleBackColor = true;
            this.btnVatandasGirisYap.Click += new System.EventHandler(this.btnVatandasGirisYap_Click);
            // 
            // btnEczaciGirisYap
            // 
            this.btnEczaciGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEczaciGirisYap.BackgroundImage")));
            this.btnEczaciGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEczaciGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEczaciGirisYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEczaciGirisYap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEczaciGirisYap.Location = new System.Drawing.Point(180, 173);
            this.btnEczaciGirisYap.Name = "btnEczaciGirisYap";
            this.btnEczaciGirisYap.Size = new System.Drawing.Size(138, 153);
            this.btnEczaciGirisYap.TabIndex = 1;
            this.btnEczaciGirisYap.Text = "Eczacı Girişi";
            this.btnEczaciGirisYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEczaciGirisYap.UseVisualStyleBackColor = true;
            this.btnEczaciGirisYap.Click += new System.EventHandler(this.btnEczaciGirisYap_Click);
            // 
            // btnDoktorGirisYap
            // 
            this.btnDoktorGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorGirisYap.BackgroundImage")));
            this.btnDoktorGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDoktorGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoktorGirisYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGirisYap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDoktorGirisYap.Location = new System.Drawing.Point(2, 173);
            this.btnDoktorGirisYap.Name = "btnDoktorGirisYap";
            this.btnDoktorGirisYap.Size = new System.Drawing.Size(141, 153);
            this.btnDoktorGirisYap.TabIndex = 0;
            this.btnDoktorGirisYap.Text = "Doktor Girişi";
            this.btnDoktorGirisYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoktorGirisYap.UseVisualStyleBackColor = true;
            this.btnDoktorGirisYap.Click += new System.EventHandler(this.btnDoktorGirisYap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 152);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(254, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVatandasGirisYap);
            this.Controls.Add(this.btnEczaciGirisYap);
            this.Controls.Add(this.btnDoktorGirisYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTANE RANDEVU MERKEZİ ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVatandasGirisYap;
        private System.Windows.Forms.Button btnEczaciGirisYap;
        private System.Windows.Forms.Button btnDoktorGirisYap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

