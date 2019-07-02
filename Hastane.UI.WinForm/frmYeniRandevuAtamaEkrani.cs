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
    public partial class frmYeniRandevuAtamaEkrani : Form
    {
        public frmYeniRandevuAtamaEkrani()
        {
            InitializeComponent();
            dtYeniRandevuTarihi.MinDate = DateTime.Now.AddDays(1);
            lblRandevuSaatleri.Visible = false;

        }

        public int doktorID;
        public int hastaID;
        public int mevcutRandevuID;
        public int tahlilTurID;

        RandevuBLL randevuBLL = new RandevuBLL();
        SeansBLL seansBLL = new SeansBLL();
        TahlilBLL tahlilBLL = new TahlilBLL();
        Button[] butonlar;
        List<int> doluSeanslar;


        public void ButonYarat()
        {
            doluSeanslar = new List<int>();

            string randevuTarihi = dtYeniRandevuTarihi.Value.ToString("yyyy-MM-dd");

            // doktorID = Convert.ToInt32(label1.Tag);


            //Bir önceki formdan gelecek olan doktorID'sini kullanacağız. !!!!!

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

        }

        Button tiklanan;

        private void Btn_Click(object sender, EventArgs e)
        {
            tiklanan = sender as Button;
            btnYeniRandevuOlustur.Enabled = true;

            if (tiklanan.BackColor == Color.DimGray)
            {
                tiklanan.BackColor = Color.White;

            }
            else
            {
                tiklanan.BackColor = Color.DimGray;

            }
        }

        private void btnYeniRandevuAra_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ButonYarat();
            lblRandevuSaatleri.Visible = true;
            btnYeniRandevuOlustur.Visible = true;

        }

        private void btnYeniRandevuOlustur_Click(object sender, EventArgs e)
        {
            //Hem Tahliller hem de randevular tablosuna verileri eklememiz lazım.

            string yeniRandevuTarihi = dtYeniRandevuTarihi.Value.ToString("yyyy-MM-dd");


            Randevu randevu = new Randevu()
            {

                HastaID = hastaID,
                DoktorID = doktorID,
                RandevuTarihi = Convert.ToDateTime(yeniRandevuTarihi),
                SeansID = Convert.ToInt32(tiklanan.Tag)

            };

            randevu.ID = randevuBLL.YeniRandevuOlustur(randevu); //Buradan bize Scope Identity dönecek

            Tahlil tahlil = new Tahlil()
            {

                TahlilTurID = tahlilTurID,
                RandevuID = mevcutRandevuID,
                YeniRandevuID = randevu.ID

            };

            int etkilenenSatirSayisi = tahlilBLL.TahlilOlustur(tahlil);

            if (etkilenenSatirSayisi > 0 && randevu.ID > 0)
            {
                MessageBox.Show("Yeni Randevu başarıyla oluşturuldu");

            }
            else
            {
                MessageBox.Show("Yeni randevu oluşturulamadı");
            }

        }


    }
}
