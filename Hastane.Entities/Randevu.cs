using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.Entities
{
    public class Randevu
    {
        public int ID { get; set; }
        public int HastaID { get; set; }

        public string HastaAdi { get; set; }

        public string HastaSoyadi { get; set; }

        public string HastaneAdi { get; set; }

        public string KlinikAdi { get; set; }

        public int DoktorID { get; set; }

        public string DoktorAdi { get; set; }

        public string DoktorSoyadi { get; set; }

        public DateTime RandevuTarihi { get; set; }

        public int SeansID { get; set; }
        public string SeansSaati { get; set; }

        public bool DoluMu { get; set; }
        public bool MuayeneGerceklestiMi { get; set; }
        public string MuayeneNotlari { get; set; }

    }
}
