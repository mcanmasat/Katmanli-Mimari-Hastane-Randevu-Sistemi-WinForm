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
    public partial class frmVatandasUyelikveGirisEkrani : Form
    {
        public frmVatandasUyelikveGirisEkrani()
        {
            InitializeComponent();
        }

        HastaBLL hastaBLL = new HastaBLL();

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.Ad = txtUyeAdi.Text;
            hasta.Soyad = txtUyeSoyadi.Text;
            //hasta.TCKN = txtUyeTCKN.Text;
            //hasta.Telefon = txtUyeTelefon.Text;

            //MaskedTextBox kullandığımız için daha önce kullandığımız TextBox'ları pasifleştirdik.

            hasta.TCKN = mskTxtTCKN.Text;
            hasta.Telefon = mskTxtTelefon.Text;
            hasta.KullaniciAdi = txtUyeMail.Text;
            hasta.Sifre = txtUyeSifre.Text;

            bool kaydedildiMi = hastaBLL.HastaKaydet(hasta);

            if (kaydedildiMi)
            {
                MessageBox.Show("Hasta başarıyla kaydedildi");
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tb = item as TextBox;

                        tb.Clear();

                    }

                    if (item is MaskedTextBox)
                    {
                        MaskedTextBox mtb = item as MaskedTextBox;
                        mtb.Clear();

                    }
                }

            }
            else
            {
                MessageBox.Show("HATA : Hasta eklenemedi");
            }

            //Burada hasta sisteme kaydolacak. Insert into Hastalar...
            //Insert ederken de şifrenin en az 8 en fazla 16 karakter olması ve özel karakter içermemesi gerekiyor.
        }


        private void btnVatandasGirisYap_Click(object sender, EventArgs e)
        {

            LoginModel user = new LoginModel();
            user.KullaniciAdi = txtKullaniciAdi.Text;
            user.Sifre = txtSifre.Text;

            Hasta girisYapan = hastaBLL.Login(user);

            if (girisYapan != null)
            {

                frmVatandasRandevuEkrani frm = new frmVatandasRandevuEkrani();

                frm.lblHastaAdSoyad.Text = "HOŞGELDİNİZ SN. " + hastaBLL.HastaAdSoyadGetir(user.KullaniciAdi);

                frm.lblHastaAdSoyad.Tag = hastaBLL.HastaIDGetir(user.KullaniciAdi);

                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Giriş bilgileriniz hatalı.\nÜye değilseniz lütfen üye olunuz.");
            }

        }

        private void txtUyeSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUyeTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUyeSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
