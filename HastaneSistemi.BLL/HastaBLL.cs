using Hastane.DAL;
using Hastane.DTO;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSistemi.BLL
{
    public class HastaBLL
    {

        //Burada Hastanın sisteme üye olması için veritabanına kaydolması gerekiyor.
        //burada ilgili Insert İşlemini gerçekleştirelim.


        HastaDAL hastaDAL = new HastaDAL();


        public List<Hasta> TumHastalariGetir()
        {
            return hastaDAL.TumHastalariGetir();
        }


        public Hasta Login(LoginModel user)
        {
            //database de userın email ve şifresiyle eşleşen kayıt olup olmadığına bakmam lazım.


            //List<Eczaci> tumUyeler = um.GetAll();

            List<Hasta> tumHastalar = this.TumHastalariGetir();

            if (tumHastalar == null)
            {
                return null;
            }

            foreach (Hasta item in tumHastalar)
            {
                if (item.KullaniciAdi == user.KullaniciAdi && item.Sifre == user.Sifre)
                {
                    return item;
                }
            }

            return null;
        }

        public bool HastaKaydet(Hasta hasta)
        {
            //şuanki durumda boş string gidip db'ya kaydoluyor. bunu kontrol etmem lazım

            //Şifrenin en az 8 en fazla 16 karakter olması olayı ayrıca özel karakter engellenmesi yapılacak.
            //Örn: hasta.Sifre.

            //hasta.Sifre.Length < 8 && hasta.Sifre.Contains(//regex gelebilir.);

            if (!string.IsNullOrWhiteSpace(hasta.Ad) && !string.IsNullOrWhiteSpace(hasta.Soyad)
                && !string.IsNullOrWhiteSpace(hasta.TCKN) && !string.IsNullOrWhiteSpace(hasta.Telefon)
                && !string.IsNullOrWhiteSpace(hasta.KullaniciAdi) && !string.IsNullOrWhiteSpace(hasta.Sifre) 
                && hasta.Sifre.Length>=8)
            {
                int etkilenenSatir = hastaDAL.HastaKaydet(hasta);

                if (etkilenenSatir > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public int HastaIDGetir(string kullaniciAdi)
        {
            return hastaDAL.HastaIDGetir(kullaniciAdi);
        }

        public string HastaAdSoyadGetir(string kullaniciAdi)
        {
            return hastaDAL.HastaAdSoyadGetir(kullaniciAdi);

        }


    }
}
