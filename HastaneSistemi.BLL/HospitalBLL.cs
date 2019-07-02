using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class HospitalBLL
    {
        HospitalDAL hastaneDAL = new HospitalDAL();
        public List<Hospital> TumHastaneleriGetir()
        {
            return hastaneDAL.TumHastaneleriGetir();
        }

        public List<Hospital> KlinikleriGetir(int hastaneKodu)
        {
            return hastaneDAL.KlinikleriGetir(hastaneKodu);
        }

        public List<Doktor> DoktorlariDoldur(int hastaneKodu, string klinikAdi)
        {
            return hastaneDAL.DoktorlariDoldur(hastaneKodu, klinikAdi);
        }

    }
}
