using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    public class RandevuSonuc
    {
        public int ID { get; set; }

        public int RandevuID { get; set; }

        public bool MuayeneGerceklestiMi { get; set; }

        public string MuayeneNotlari { get; set; }


    }
}
