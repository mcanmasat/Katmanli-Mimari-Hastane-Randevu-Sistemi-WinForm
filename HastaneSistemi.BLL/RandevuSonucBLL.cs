using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class RandevuSonucBLL
    {

        RandevuSonucDAL randevuSonucDAL = new RandevuSonucDAL();

        public bool RandevuSonucEkle(RandevuSonuc randevuSonuc)
        {

            int etkilenenSatir = randevuSonucDAL.RandevuSonucEkle(randevuSonuc);

            if (etkilenenSatir > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
