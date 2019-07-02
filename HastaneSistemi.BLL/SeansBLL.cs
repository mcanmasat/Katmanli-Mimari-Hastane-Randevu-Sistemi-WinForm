using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class SeansBLL
    {
        SeansDAL seansDAL = new SeansDAL();


        public List<Seans> SeanslariGetir(string randevuTarihi, int doktorID)
        {
            return seansDAL.SeanslariGetir(randevuTarihi, doktorID);
        }

        public List<string> SeansAdlariniGetir()
        {
            return seansDAL.SeansAdlariniGetir();
        }

        public List<int> DoluSeansIdleriGetir(string randevuTarihi, int doktorID)
        {
            return seansDAL.DoluSeansIdleriGetir(randevuTarihi, doktorID);
        }
    }
}
