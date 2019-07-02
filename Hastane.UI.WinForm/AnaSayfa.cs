using Hastane.DTO;
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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        // EczaciBLL eczaciBLL = new EczaciBLL();

        DoktorBLL doktorBLL = new DoktorBLL();

        private void btnDoktorGirisYap_Click(object sender, EventArgs e)
        {
            frmDoktorGirisEkrani frm = new frmDoktorGirisEkrani();
            frm.ShowDialog();
        }

        private void btnEczaciGirisYap_Click(object sender, EventArgs e)
        {
            frmEczaciGirisEkrani frm = new frmEczaciGirisEkrani();
            frm.ShowDialog();
        }

        private void btnVatandasGirisYap_Click(object sender, EventArgs e)
        {
            frmVatandasUyelikveGirisEkrani frm = new frmVatandasUyelikveGirisEkrani();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        //private void btnGiris_Click(object sender, EventArgs e)
        //{
        //    #region Eczacı Login İşlemi
        //    LoginModel user = new LoginModel();
        //    user.KullaniciAdi = txtAd.Text;
        //    user.Sifre = txtSifre.Text;

        //    Eczaci girisYapan = eczaciBLL.Login(user);

        //    if (girisYapan != null)
        //    {
        //        //Eczacı Formunu oluşturduğumuzda aşağıdaki yorum satırı içindeki kodları kullanacağız.

        //        //frmEczaciSayfasi frm = new frmEczaciSayfasi();
        //        //frm.loginEkrani = this;
        //        //this.Hide();
        //        //frm.Show();
        //        MessageBox.Show("Eczacı Giriş bilgileri doğru");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Eczacı Giriş bilgileri hatalı!");
        //    }
        //    #endregion


        //}


    }
}

