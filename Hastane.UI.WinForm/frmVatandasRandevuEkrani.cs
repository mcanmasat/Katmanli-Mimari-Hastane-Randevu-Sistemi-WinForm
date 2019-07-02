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
    public partial class frmVatandasRandevuEkrani : Form
    {
        public frmVatandasRandevuEkrani()
        {
            InitializeComponent();

            //Tarih seçeceğimiz takvimin güncel tarihten önceki tarihi seçtirmesini engelledik.
            dtRandevuTarihi.MinDate = DateTime.Now;
            btnRandevuOlustur.Enabled = false;

        }

        frmVatandasUyelikveGirisEkrani frm;
        public int hastaID;
        public string hastaAdSoyad;

        Button[] butonlar;
        List<int> doluSeanslar;

        public void ButonYarat()
        {
            doluSeanslar = new List<int>();

            string randevuTarihi = dtRandevuTarihi.Value.ToString("yyyy-MM-dd");

            Doktor secilenDoktor = cmbDoktorlar.SelectedItem as Doktor;

            int doktorID = secilenDoktor.ID;

            doluSeanslar = seansBLL.DoluSeansIdleriGetir(randevuTarihi, doktorID);


            butonlar = new Button[14];
            Button btn;

            List<string> seanslar = new List<string>();
            seanslar = seansBLL.SeansAdlariniGetir();

            for (int i = 1; i <= butonlar.Length; i++)
            {
                btn = new Button();
                btn.FlatStyle = FlatStyle.Popup;
                btn.Width = 114;
                btn.Height = 30;
                btn.Tag = i;
                btn.Text = seanslar[i - 1];
                //btn.BackColor = Color.Green;
                btn.BackColor = Color.White;

                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);

                if (doluSeanslar.Contains(i))
                {
                    //btn.BackColor = Color.Red;
                    btn.BackColor = Color.DimGray;

                    btn.Enabled = false;
                }

            }

            //for (int i = 0; i < butonlar.Length; i++)
            //{
            //    btn = new Button();
            //    btn.FlatStyle = FlatStyle.Popup;
            //    btn.Width = 114;
            //    btn.Height = 30;
            //    btn.Tag = i + 1;
            //    btn.Text = seanslar[i];
            //    btn.BackColor = Color.Green;
            //    btn.Click += Btn_Click;
            //    flowLayoutPanel1.Controls.Add(btn);

            //}

        }

        Button tiklanan;
        private void Btn_Click(object sender, EventArgs e)
        {
            tiklanan = sender as Button;
            btnRandevuOlustur.Enabled = true;


            if (tiklanan.BackColor == Color.DimGray)
            {
                tiklanan.BackColor = Color.White;

            }
            else
            {
                tiklanan.BackColor = Color.DimGray;

            }

        }

        HospitalBLL hastaneBLL = new HospitalBLL();
        SeansBLL seansBLL = new SeansBLL();
        RandevuBLL randevuBLL = new RandevuBLL();

        private void frmVatandasRandevuEkrani_Load(object sender, EventArgs e)
        {
            //Tüm hastaneleri çekip ComboBox'a dolduracağız.

            btnRandevuOlustur.Visible = false;
            lblRandevuSaatleri.Visible = false;

            cmbHastaneler.DataSource = hastaneBLL.TumHastaneleriGetir();
            //ComboBox'da hastane isimlerinin düzgün görüntülenebilmesi için Display Member belirtmemiz gerekiyor.
            cmbHastaneler.DisplayMember = "HastaneAdi";
            cmbHastaneler.ValueMember = "HastaneKodu";

            //hastaID = frm.yeniHasta.ID;
            //lblHastaAdSoyad.Text = hastaID.ToString();

        }

        private void cmbHastaneler_SelectedIndexChanged(object sender, EventArgs e)
        {

            Hospital secilen = cmbHastaneler.SelectedItem as Hospital;
            int hastaneKodu = secilen.HastaneKodu;
            cmbDepartmanlar.DataSource = hastaneBLL.KlinikleriGetir(hastaneKodu);
            cmbDepartmanlar.DisplayMember = "KlinikAdi";
        }

        private void cmbDepartmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hospital secilenHastane = cmbHastaneler.SelectedItem as Hospital;

            Hospital secilenKlinik = cmbDepartmanlar.SelectedItem as Hospital;

            int hastaneKodu = secilenHastane.HastaneKodu;
            string klinikAdi = secilenKlinik.KlinikAdi;

            cmbDoktorlar.DataSource = hastaneBLL.DoktorlariDoldur(hastaneKodu, klinikAdi);

            cmbDoktorlar.DisplayMember = "FullName";
            cmbDoktorlar.ValueMember = "ID";

        }

        public void btnRandevuAra_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            ButonYarat();
            lblRandevuSaatleri.Visible = true;
            btnRandevuOlustur.Visible = true;

            // dataGridView1.DataSource = seansBLL.SeanslariGetir(randevuTarihi, doktorID);

        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            //Randevu oluşturulacak.

            try
            {
                string randevuTarihi = dtRandevuTarihi.Value.ToString("yyyy-MM-dd");

                Randevu randevu = new Randevu()
                {
                    HastaID = Convert.ToInt32(lblHastaAdSoyad.Tag),
                    DoktorID = Convert.ToInt32(cmbDoktorlar.SelectedValue),
                    RandevuTarihi = Convert.ToDateTime(randevuTarihi),
                    SeansID = Convert.ToInt32(tiklanan.Tag)

                };

                bool kaydedildiMi = randevuBLL.RandevuOlustur(randevu);

                if (kaydedildiMi)
                {
                    MessageBox.Show($"Randevu oluşturuldu\n\nHastaneAdı:{cmbHastaneler.Text}\nKlinik Adı:{cmbDepartmanlar.Text}\nDoktor Adı:{cmbDoktorlar.Text}\nTarih:{randevuTarihi}\nSaat:{tiklanan.Text}", "GEÇMİŞ OLSUN");
                    tiklanan = null;
                }
                else
                {
                    MessageBox.Show("Hata");
                }

                //Burada var olan seansları anlık yenilemek için bu methodu çağırdık.
                btnRandevuAra_Click(null, null);
            }
            catch (Exception)
            {

                MessageBox.Show("Seans seçmeden randevu oluşturamazsınız.\nLütfen müsait seanslardan birini seçiniz.");

            }

        }

        private void randevularimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaRandevuBilgileri frm = new frmHastaRandevuBilgileri();
            frm.hastaID = Convert.ToInt32(lblHastaAdSoyad.Tag);
            frm.ShowDialog();
        }
    }
}
