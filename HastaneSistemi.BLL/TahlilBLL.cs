using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class TahlilBLL
    {
        TahlilDAL tahlilDAL = new TahlilDAL();

        public int TahlilOlustur(Tahlil tahlil)
        {
            return tahlilDAL.TahlilOlustur(tahlil);
        }




    }
}
