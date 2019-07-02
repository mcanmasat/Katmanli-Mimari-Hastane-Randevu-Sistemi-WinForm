using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class TeshisBLL
    {
        TeshisDAL teshisDAL = new TeshisDAL();

        public List<Teshis> TumTeshisleriGetir()
        {
            return teshisDAL.TumTeshisleriGetir();
        }



    }
}
