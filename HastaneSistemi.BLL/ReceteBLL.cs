using Hastane.DAL;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class ReceteBLL
    {
        ReceteDAL receteDAL = new ReceteDAL();

        public int ReceteEkle(Recete recete)
        {
            return receteDAL.ReceteEkle(recete);
        }

    }
}
