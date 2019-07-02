using Hastane.DTO;
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
    public partial class frmDoktorGirisEkrani : Form
    {

        public frmDoktorGirisEkrani()
        {
            InitializeComponent();
        }

        DoktorBLL doktorBLL = new DoktorBLL();
        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            LoginModel user = new LoginModel();
            user.KullaniciAdi = txtKullaniciAdi.Text;
            user.Sifre = txtSifre.Text;

            Doktor girisYapan = doktorBLL.Login(user);

            if (girisYapan != null)
            {

                frmDoktorIslemEkrani frm = new frmDoktorIslemEkrani();

                frm.lblDoktorUnvanAdSoyad.Text = "HOŞGELDİNİZ SN. " + doktorBLL.DoktorUnvanAdSoyadGetir(user.KullaniciAdi);

                frm.lblDoktorUnvanAdSoyad.Tag = doktorBLL.DoktorIDGetir(user.KullaniciAdi);

                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Doktor Giriş bilgileri hatalı!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
