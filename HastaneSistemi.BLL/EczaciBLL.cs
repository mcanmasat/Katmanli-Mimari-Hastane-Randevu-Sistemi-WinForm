using Hastane.DAL;
using Hastane.DTO;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class EczaciBLL
    {



        //Sisteme login işleminin kontrol edildiği methodu yazalım.

        

        EczaciDAL eczaciDal = new EczaciDAL();

        public List<Eczaci> TumEczacilariGetir()
        {
            return eczaciDal.TumEczacilariGetir();
        }


        public Eczaci Login(LoginModel user)
        {
            //database de userın email ve şifresiyle eşleşen kayıt olup olmadığına bakmam lazım.


            //List<Eczaci> tumUyeler = um.GetAll();

            List<Eczaci> tumEczacilar = this.TumEczacilariGetir();

            if (tumEczacilar == null)
            {
                return null;
            }

            foreach (Eczaci item in tumEczacilar)
            {
                if (item.KullaniciAdi == user.KullaniciAdi && item.Sifre == user.Sifre)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
