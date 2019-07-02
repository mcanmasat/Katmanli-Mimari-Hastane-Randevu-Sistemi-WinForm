using Hastane.DTO;
using Hastane.Entities;
using HastaneSistemi.BLL;
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
    public partial class frmEczaciGirisEkrani : Form
    {
        public frmEczaciGirisEkrani()
        {
            InitializeComponent();
        }

        EczaciBLL eczaciBLL = new EczaciBLL();
        private void btnEczaciGiris_Click(object sender, EventArgs e)
        {
            LoginModel user = new LoginModel();
            user.KullaniciAdi = txtKullaniciAdi.Text;
            user.Sifre = txtSifre.Text;

            Eczaci girisYapan = eczaciBLL.Login(user);

            if (girisYapan != null)
            {

                frmEczaciIslemEkrani frm = new frmEczaciIslemEkrani();
                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Eczacı Giriş bilgileri hatalı!");
            }
        }
    }
}
