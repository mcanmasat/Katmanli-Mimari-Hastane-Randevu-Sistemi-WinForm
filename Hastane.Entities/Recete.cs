using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.Entities
{
    public class Recete
    {
        public int ReceteNumarasi { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public int TeshisID { get; set; }
        private DateTime _tarih;

        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }

    }
}
