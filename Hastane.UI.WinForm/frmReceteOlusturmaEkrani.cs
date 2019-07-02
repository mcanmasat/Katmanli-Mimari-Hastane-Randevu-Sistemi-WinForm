using HastaneSistemi.BLL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.UI.WinForm
{
    public partial class frmReceteOlusturmaEkrani : Form
    {
        public frmReceteOlusturmaEkrani()
        {
            InitializeComponent();
        }

        IlacBLL ilacBLL = new IlacBLL();
        ReceteDetayBLL receteDetayBLL = new ReceteDetayBLL();

        private void frmReceteOlusturmaEkrani_Load(object sender, EventArgs e)
        {
            #region İlaçları Doldurma
            cmbIlaclar.DataSource = ilacBLL.TumIlaclariGetir();
            cmbIlaclar.DisplayMember = "Adi";
            cmbIlaclar.ValueMember = "ID";
            #endregion

        }
        ListViewItem lvi;
        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            Ilac ilac = cmbIlaclar.SelectedItem as Ilac;

            lvi = new ListViewItem();

            ReceteDetay receteDetay = new ReceteDetay()
            {
                ReceteNumarasi = Convert.ToInt32(txtReceteNumarasi.Text),
                IlacID = ilac.ID,
                Notlar = txtIlacNotlari.Text
            };

            int etkilenenSatirSayisi = receteDetayBLL.ReceteyeIlacEkle(receteDetay);

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("İlaç ekleme işlemi başarılı");

                lvi.Text = cmbIlaclar.Text;
                lvi.SubItems.Add(txtIlacNotlari.Text);
                lstIlaclar.Items.Add(lvi);
                txtIlacNotlari.Text = string.Empty;


            }
            else
            {
                MessageBox.Show("HATA");
            }

        }
    }
}
