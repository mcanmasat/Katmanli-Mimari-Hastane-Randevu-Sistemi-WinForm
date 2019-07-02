namespace Hastane.UI.WinForm
{
    partial class frmHastaRandevuBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaRandevuBilgileri));
            this.dgwHastaRandevulari = new System.Windows.Forms.DataGridView();
            this.btnRandevuIptalEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHastaRandevulari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwHastaRandevulari
            // 
            this.dgwHastaRandevulari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwHastaRandevulari.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgwHastaRandevulari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHastaRandevulari.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwHastaRandevulari.Location = new System.Drawing.Point(0, 0);
            this.dgwHastaRandevulari.Name = "dgwHastaRandevulari";
            this.dgwHastaRandevulari.ReadOnly = true;
            this.dgwHastaRandevulari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwHastaRandevulari.Size = new System.Drawing.Size(774, 297);
            this.dgwHastaRandevulari.TabIndex = 0;
            // 
            // btnRandevuIptalEt
            // 
            this.btnRandevuIptalEt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRandevuIptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandevuIptalEt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRandevuIptalEt.Image = ((System.Drawing.Image)(resources.GetObject("btnRandevuIptalEt.Image")));
            this.btnRandevuIptalEt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandevuIptalEt.Location = new System.Drawing.Point(250, 317);
            this.btnRandevuIptalEt.Name = "btnRandevuIptalEt";
            this.btnRandevuIptalEt.Size = new System.Drawing.Size(197, 83);
            this.btnRandevuIptalEt.TabIndex = 1;
            this.btnRandevuIptalEt.Text = "Randevuyu İptal Et";
            this.btnRandevuIptalEt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRandevuIptalEt.UseVisualStyleBackColor = false;
            this.btnRandevuIptalEt.Click += new System.EventHandler(this.btnRandevuIptalEt_Click);
            // 
            // frmHastaRandevuBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 422);
            this.Controls.Add(this.btnRandevuIptalEt);
            this.Controls.Add(this.dgwHastaRandevulari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHastaRandevuBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevularım";
            this.Load += new System.EventHandler(this.frmHastaRandevuBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHastaRandevulari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwHastaRandevulari;
        private System.Windows.Forms.Button btnRandevuIptalEt;
    }
}