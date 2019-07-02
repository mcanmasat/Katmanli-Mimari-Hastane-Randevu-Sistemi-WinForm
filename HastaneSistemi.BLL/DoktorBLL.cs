using Hastane.DAL;
using Hastane.DTO;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class DoktorBLL
    {

        DoktorDAL doktorDAL = new DoktorDAL();

        public List<Doktor> TumDoktorlariGetir()
        {
            return doktorDAL.TumDoktorlariGetir();
        }


        public Doktor Login(LoginModel user)
        {
            //database de userın email ve şifresiyle eşleşen kayıt olup olmadığına bakmam lazım.


            List<Doktor> tumDoktorlar = this.TumDoktorlariGetir();

            if (tumDoktorlar == null)
            {
                return null;
            }

            foreach (Doktor item in tumDoktorlar)
            {
                if (item.KullaniciAdi == user.KullaniciAdi && item.Sifre == user.Sifre)
                {
                    return item;
                }
            }

            return null;
        }

        public int DoktorIDGetir(string kullaniciAdi)
        {
            return doktorDAL.DoktorIDGetir(kullaniciAdi);
        }

        public string DoktorUnvanAdSoyadGetir(string kullaniciAdi)
        {
            return doktorDAL.DoktorUnvanAdSoyadGetir(kullaniciAdi);
        }


    }
}
