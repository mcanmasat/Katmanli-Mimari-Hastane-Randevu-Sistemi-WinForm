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
    public partial class frmHastaRandevuBilgileri : Form
    {
        public frmHastaRandevuBilgileri()
        {
            InitializeComponent();
        }


        RandevuBLL randevuBLL = new RandevuBLL();
        public int hastaID;

        private void frmHastaRandevuBilgileri_Load(object sender, EventArgs e)
        {

            dgwHastaRandevulari.DataSource = randevuBLL.HastaRandevulariGoruntule(hastaID);
            dgwHastaRandevulari.Columns["ID"].Visible = false;
            dgwHastaRandevulari.Columns["HastaID"].Visible = false;
            dgwHastaRandevulari.Columns["HastaAdi"].Visible = false;
            dgwHastaRandevulari.Columns["HastaSoyadi"].Visible = false;
            dgwHastaRandevulari.Columns["DoktorID"].Visible = false;
            dgwHastaRandevulari.Columns["SeansID"].Visible = false;
            dgwHastaRandevulari.Columns["DoluMu"].Visible = false;
            dgwHastaRandevulari.Columns["MuayeneGerceklestiMi"].Visible = false;
            dgwHastaRandevulari.Columns["MuayeneNotlari"].Visible = false;
        }

        private void btnRandevuIptalEt_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dgwHastaRandevulari.SelectedRows)  //Seçili Satırları Silme
            {


                int randevuID = Convert.ToInt32(item.Cells["ID"].Value); //1.kolon bizde HastaID'si
                randevuBLL.RandevuIptalEt(randevuID);
            }

            ListeyiYenile();

        }

        private void ListeyiYenile()
        {
            dgwHastaRandevulari.DataSource = randevuBLL.HastaRandevulariGoruntule(hastaID);
        }


    }
}
