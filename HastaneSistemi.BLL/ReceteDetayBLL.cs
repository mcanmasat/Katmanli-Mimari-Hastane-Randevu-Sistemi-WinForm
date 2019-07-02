using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class ReceteDetayBLL
    {
        ReceteDetayDAL receteDetayDAL = new ReceteDetayDAL();


        public int ReceteyeIlacEkle(ReceteDetay receteDetay)
        {
            return receteDetayDAL.ReceteyeIlacEkle(receteDetay);
        }

        public List<ReceteDetay> EczaciIlacSorgula(int receteNumarasi)
        {

            return receteDetayDAL.EczaciIlacSorgula(receteNumarasi);
        }

        public List<ReceteDetay> HastaGecmisReceteSorgula(string tckn)
        {
            return receteDetayDAL.HastaGecmisReceteSorgula(tckn);
        }



    }
}
