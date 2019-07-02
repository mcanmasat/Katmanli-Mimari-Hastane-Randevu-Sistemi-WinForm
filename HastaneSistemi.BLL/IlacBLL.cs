using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class IlacBLL
    {
        IlacDAL ilacDAL = new IlacDAL();

        public List<Ilac> TumIlaclariGetir()
        {
            return ilacDAL.TumIlaclariGetir();
        }


    }
}
