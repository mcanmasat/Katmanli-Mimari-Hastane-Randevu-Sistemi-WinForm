using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class RandevuBLL
    {
        RandevuDAL randevuDAL = new RandevuDAL();

        public bool RandevuOlustur(Randevu randevu)
        {
            //şuanki durumda boş string gidip db'ya kaydoluyor. bunu kontrol etmem lazım

            //Şifrenin en az 8 en fazla 16 karakter olması olayı ayrıca özel karakter engellenmesi yapılacak.
            //Örn: hasta.Sifre.

            //hasta.Sifre.Length < 8 && hasta.Sifre.Contains(//regex gelebilir.);

            int etkilenenSatir = randevuDAL.RandevuOlustur(randevu);

            if (etkilenenSatir > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Randevu> HastaRandevulariGoruntule(int hastaID)
        {

            return randevuDAL.HastaRandevulariGoruntule(hastaID);
        }

        public int RandevuIptalEt(int randevuID)
        {
            return randevuDAL.RandevuIptalEt(randevuID);
        }

        public List<Randevu> DoktorRandevulariGoruntule(int doktorID, string bugununTarihi)
        {
            return randevuDAL.DoktorRandevulariGoruntule(doktorID, bugununTarihi);
        }

        public int YeniRandevuOlustur(Randevu randevu)
        {
            return randevuDAL.YeniRandevuOlustur(randevu);
        }



    }
}
