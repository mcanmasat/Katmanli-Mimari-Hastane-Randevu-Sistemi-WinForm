using Hastane.Entities;
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
    public partial class frmDoktorIslemEkrani : Form
    {

        public frmDoktorIslemEkrani()
        {
            InitializeComponent();
        }

        RandevuBLL randevuBLL = new RandevuBLL();
        DoktorBLL doktorBLL = new DoktorBLL();
        TeshisBLL teshisBLL = new TeshisBLL();
        TahlilTurBLL tahlilTurBLL = new TahlilTurBLL();
        RandevuSonucBLL randevuSonucBLL = new RandevuSonucBLL();
        ReceteBLL receteBLL = new ReceteBLL();

        public int doktorID;
        public string bugununTarihi;

        private void calismaGunuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Buraya başka bir olay gelecek.
        }

        private void frmDoktorIslemEkrani_Load(object sender, EventArgs e)
        {
            //Bugünün tarihini ve doktorun ID'sini methoda parametre olarak göndereceğiz.

            doktorID = Convert.ToInt32(lblDoktorUnvanAdSoyad.Tag);

            bugununTarihi = DateTime.Now.ToString("yyyy-MM-dd");

            ListeyiYenile();

            cmbTahlilTurleri.Enabled = false;
            btnYeniRandevuOlustur.Enabled = false;


            #region Teşhisleri Doldurma
            cmbTeshisler.DataSource = teshisBLL.TumTeshisleriGetir();
            cmbTeshisler.DisplayMember = "Adi";
            cmbTeshisler.ValueMember = "ID";
            #endregion


            #region Tahlil Türlerini Doldurma
            cmbTahlilTurleri.DataSource = tahlilTurBLL.TumTahlilTurleriniGetir();
            cmbTahlilTurleri.DisplayMember = "Adi";
            cmbTahlilTurleri.ValueMember = "ID";
            #endregion

        }

        private void ListeyiYenile()
        {
            dgwGununRandevulari.DataSource = randevuBLL.DoktorRandevulariGoruntule(doktorID, bugununTarihi);

            dgwGununRandevulari.Columns["ID"].Visible = false;
            dgwGununRandevulari.Columns["HastaID"].Visible = false;
            dgwGununRandevulari.Columns["DoktorID"].Visible = false;
            dgwGununRandevulari.Columns["DoktorAdi"].Visible = false;
            dgwGununRandevulari.Columns["DoktorSoyadi"].Visible = false;
            dgwGununRandevulari.Columns["SeansID"].Visible = false;
            dgwGununRandevulari.Columns["HastaneAdi"].Visible = false;
            dgwGununRandevulari.Columns["KlinikAdi"].Visible = false;
            dgwGununRandevulari.Columns["DoluMu"].Visible = false;
            dgwGununRandevulari.Columns["MuayeneGerceklestiMi"].Visible = false;
            dgwGununRandevulari.Columns["MuayeneNotlari"].Visible = false;

        }

        private void dgwGununRandevulari_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string hastaAdi = dgwGununRandevulari.CurrentRow.Cells["HastaAdi"].Value.ToString();
            string hastaSoyadi = dgwGununRandevulari.CurrentRow.Cells["HastaSoyadi"].Value.ToString();


            txtHastaAdSoyad.Text = hastaAdi + " " + hastaSoyadi;
        }

        private void chkHastaGelmedi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHastaGelmedi.Checked)
            {
                cmbTeshisler.Enabled = false;
                chkTeshisKonulamadi.Enabled = false;

                btnReceteOlustur.Enabled = false;
            }
            else
            {
                cmbTeshisler.Enabled = true;
                chkTeshisKonulamadi.Enabled = true;

                btnReceteOlustur.Enabled = true;

            }
        }

        private void btnReceteOlustur_Click(object sender, EventArgs e)
        {

            try
            {
                Teshis teshis = cmbTeshisler.SelectedItem as Teshis;

                Recete recete = new Recete()
                {
                    HastaID = Convert.ToInt32(dgwGununRandevulari.CurrentRow.Cells["HastaID"].Value),
                    DoktorID = Convert.ToInt32(lblDoktorUnvanAdSoyad.Tag),
                    TeshisID = teshis.ID,
                    Tarih = DateTime.Now,  //Gerekirse DateTime formatı değiştirebiliriz.

                };

                recete.ReceteNumarasi = receteBLL.ReceteEkle(recete);


                if (recete.ReceteNumarasi > 0)
                {
                    MessageBox.Show("Reçete oluşturuldu");
                    ListeyiYenile();
                }
                else
                {
                    MessageBox.Show("Reçete oluşturulamadı");
                }

                frmReceteOlusturmaEkrani frm = new frmReceteOlusturmaEkrani();
                frm.txtReceteNumarasi.Text = recete.ReceteNumarasi.ToString();
                frm.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Randevu seçimi yapmadan reçete oluşturamazsınız");
            }
        }

        private void chkTeshisKonulamadi_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkTeshisKonulamadi.Checked)
            {

                chkHastaGelmedi.Enabled = false;
                cmbTahlilTurleri.Enabled = true;
                btnYeniRandevuOlustur.Enabled = true;
                cmbTeshisler.Enabled = false;

                btnReceteOlustur.Enabled = false;
                btnOnayla.Enabled = false;

            }
            else
            {

                chkHastaGelmedi.Enabled = true;
                cmbTahlilTurleri.Enabled = false;
                btnYeniRandevuOlustur.Enabled = false;
                cmbTeshisler.Enabled = true;

                btnReceteOlustur.Enabled = true;
                btnOnayla.Enabled = true;

            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {

            try
            {
                int randevuID = Convert.ToInt32(dgwGununRandevulari.CurrentRow.Cells["ID"].Value);
                bool durum;

                if (chkHastaGelmedi.Checked)
                {
                    durum = false;

                }

                else
                {
                    durum = true;
                }


                RandevuSonuc randevuSonuc = new RandevuSonuc()
                {
                    RandevuID = randevuID,
                    MuayeneGerceklestiMi = durum,
                    MuayeneNotlari = txtMuayeneNotlari.Text

                };

                bool kaydedildiMi = randevuSonucBLL.RandevuSonucEkle(randevuSonuc);

                if (kaydedildiMi)
                {
                    MessageBox.Show("Kayıt başarılı");

                    if (chkHastaGelmedi.Checked)
                    {
                        ListeyiYenile();

                    }

                }
                else
                {
                    MessageBox.Show("Kayıt eklenemedi.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Randevu seçimi yapmadan muayeneyi onaylayamazsınız.");
            }
        }

        private void btnYeniRandevuOlustur_Click(object sender, EventArgs e)
        {
            //Bu butona tıklandığında doktor hasta için bir tahlil belirleyip yeni bir randevu tarihi atayacak.

            TahlilTur tahlilTur = cmbTahlilTurleri.SelectedItem as TahlilTur;


            frmYeniRandevuAtamaEkrani frm = new frmYeniRandevuAtamaEkrani();

            frm.doktorID = this.doktorID;
            frm.hastaID = Convert.ToInt32(dgwGununRandevulari.CurrentRow.Cells["HastaID"].Value);
            frm.tahlilTurID = tahlilTur.ID;
            frm.mevcutRandevuID = Convert.ToInt32(dgwGununRandevulari.CurrentRow.Cells["ID"].Value);

            ListeyiYenile();
            //frm.label1.Tag = doktorID;
            //frm.label1.Text = doktorID.ToString();

            frm.ShowDialog();






        }
    }
}
