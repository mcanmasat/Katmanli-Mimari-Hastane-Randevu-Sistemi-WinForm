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
    public partial class frmEczaciIslemEkrani : Form
    {
        public frmEczaciIslemEkrani()
        {
            InitializeComponent();
        }

        ListViewItem lvi;
        ReceteDetayBLL receteDetayBLL = new ReceteDetayBLL();

        private void btnAra_Click(object sender, EventArgs e)
        {
            //Reçete numarası girilen İlacın bilgileri ListView'da görüntülenecek.

            lstIlacAdlari.Items.Clear();

            List<ReceteDetay> receteDetaylar = new List<ReceteDetay>();

            if (!string.IsNullOrWhiteSpace(mskTxtReceteNumarasi.Text))
            {
                receteDetaylar = receteDetayBLL.EczaciIlacSorgula(Convert.ToInt32(mskTxtReceteNumarasi.Text));

                foreach (ReceteDetay item in receteDetaylar)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.IlacAdi;
                    lvi.SubItems.Add(item.Notlar);

                    lstIlacAdlari.Items.Add(lvi);

                }

                mskTxtReceteNumarasi.Text = string.Empty;
            }

            else
            {
                MessageBox.Show("Reçete numarası girmeden sorgulama yapamazsınız");
            }

        }

        private void frmEczaciIslemEkrani_Load(object sender, EventArgs e)
        {
            lblEczaciAdSoyad.Text = "HOŞGELDİNİZ";
        }

        private void btnTCKNReceteSorgula_Click(object sender, EventArgs e)
        {
            //Hastanın TCKN bilgisine göre geçmiş ilaç bilgilerini ListView'e dolduralım.


            lstGecmisReceteIlaclari.Items.Clear();

            List<ReceteDetay> receteDetaylar = new List<ReceteDetay>();

            if (!string.IsNullOrWhiteSpace(mskTxtHastaTCKN.Text))
            {
                receteDetaylar = receteDetayBLL.HastaGecmisReceteSorgula(mskTxtHastaTCKN.Text);

                foreach (ReceteDetay item in receteDetaylar)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.ReceteNumarasi.ToString();
                    lvi.SubItems.Add(item.IlacAdi);
                    lvi.SubItems.Add(item.Notlar);

                    lstGecmisReceteIlaclari.Items.Add(lvi);

                }

                mskTxtHastaTCKN.Text = string.Empty;
            }

            else
            {
                MessageBox.Show("TC Kimlik bilgisi girmeden sorgulama yapamazsınız");
            }

        }
    }
}
