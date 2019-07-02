using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.Entities
{
    public class Hospital

    {
        public int ID { get; set; }
        public int HastaneKodu { get; set; }
        public string HastaneAdi { get; set; }
        public string KlinikAdi { get; set; }
        public string Ilce { get; set; }


    }
}
