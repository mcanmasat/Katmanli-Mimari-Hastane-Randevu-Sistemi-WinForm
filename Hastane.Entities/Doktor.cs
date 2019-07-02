using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.Entities
{
    public class Doktor
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        private string fullName;

        public string FullName
        {
            get { return this.Ad + " " + this.Soyad; }

        }

        public string Brans { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Unvan { get; set; }
        public string Telefon { get; set; }
        private DateTime dtarihi;
        public DateTime DogumTarihi
        {
            get { return dtarihi; }
            set { dtarihi = value; }
        }
        public int HastaneID { get; set; }
        //Buraya Hastane Tipinde bir değer gelebilir.



    }
}
