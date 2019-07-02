using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class TahlilTurBLL
    {
        TahlilTurDAL tahlilTurDAL = new TahlilTurDAL();

        public List<TahlilTur> TumTahlilTurleriniGetir()
        {
            return tahlilTurDAL.TumTahlilTurleriniGetir();
        }


    }
}
