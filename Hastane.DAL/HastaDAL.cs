using Hastane.Entities;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class HastaDAL
    {
        //03.05.2019 

        //İlk oluşturulduğunda içinde Hastayla ilgili veri olmadığı için veri çekim işlemi denenmedi.

        //Burada Tüm hastaları listelemek için bir Stored Procedure kullandık.

        //public DataTable TumHastalariGetir()
        //{
        //    SqlCommand cmd = new SqlCommand("sp_HastalariGetir", DBConnection.Conn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    DataTable dt = new DataTable();

        //    dt.Load(cmd.ExecuteReader());

        //    return dt;
        //}

        SqlDataReader rdr;
        public List<Hasta> TumHastalariGetir()
        {
            List<Hasta> hastalar = new List<Hasta>();
            SqlCommand cmd = new SqlCommand("sp_HastalariGetir", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Hasta hasta;
                    while (rdr.Read())
                    {
                        hasta = new Hasta()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Ad = rdr["Ad"].ToString(),
                            Soyad = rdr["Soyad"].ToString(),
                            TCKN = rdr["TCKN"].ToString(),
                            Telefon = rdr["Telefon"].ToString(),
                            KullaniciAdi = rdr["KullaniciAdi"].ToString(),
                            Sifre = rdr["Sifre"].ToString()

                        };
                        hastalar.Add(hasta);
                    }
                }
                return hastalar;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                rdr.Close();
                DBConnection.Conn.Close();
            }
        }

        public int HastaKaydet(Hasta hasta)
        {

            SqlCommand cmd = new SqlCommand("sp_HastaUyeKaydet", DBConnection.Conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ad", hasta.Ad);
            cmd.Parameters.AddWithValue("@soyad", hasta.Soyad);
            cmd.Parameters.AddWithValue("@tckn", hasta.TCKN);
            cmd.Parameters.AddWithValue("@kullaniciAdi", hasta.KullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", hasta.Sifre);
            cmd.Parameters.AddWithValue("@telefon", hasta.Telefon);
            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }

                return Convert.ToInt32(cmd.ExecuteNonQuery()); //Etkilenen satır sayısı döner. 0'dan büyükse işlem başarılı demektir.
            }
            catch (Exception)
            {
                return -1; //Insert işlemi gerçekleşmezse Effected Rows -1 olacağından hatada buraya düşecek.
            }
            finally
            {
                DBConnection.Conn.Close();
            }

        }

        public int HastaIDGetir(string kullaniciAdi)
        {
            SqlCommand cmd = new SqlCommand("sp_HastaIDGetir", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }

                return Convert.ToInt32(cmd.ExecuteScalar()); //Etkilenen satır sayısı döner. 0'dan büyükse işlem başarılı demektir.
            }
            catch (Exception)
            {
                return -1; //Insert işlemi gerçekleşmezse Effected Rows -1 olacağından hatada buraya düşecek.
            }
            finally
            {
                DBConnection.Conn.Close();
            }

        }

        public string HastaAdSoyadGetir(string kullaniciAdi)
        {
            SqlCommand cmd = new SqlCommand("sp_HastaAdSoyadGetir", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }

                return cmd.ExecuteScalar().ToString(); //Etkilenen satır sayısı döner. 0'dan büyükse işlem başarılı demektir.
            }
            catch (Exception)
            {
                return (-1).ToString(); //Insert işlemi gerçekleşmezse Effected Rows -1 olacağından hatada buraya düşecek.
            }
            finally
            {
                DBConnection.Conn.Close();
            }

        }
















        //public Hasta HastaIDGetir(string kullaniciAdi)
        //{
        //    Hasta hasta = new Hasta();
        //    SqlCommand cmd = new SqlCommand("sp_HastaIDGetir", DBConnection.Conn);

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);

        //    try
        //    {
        //        if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
        //        {
        //            DBConnection.Conn.Open();
        //        }
        //        rdr = cmd.ExecuteReader();
        //        if (rdr.HasRows)
        //        {

        //            while (rdr.Read())
        //            {
        //                hasta = new Hasta()
        //                {
        //                    ID = Convert.ToInt32(rdr["ID"]),
        //                    Ad = rdr["Ad"].ToString(),
        //                    Soyad = rdr["Soyad"].ToString()

        //                };

        //            }
        //        }
        //        return hasta;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        rdr.Close();
        //        DBConnection.Conn.Close();
        //    }
        //}




















    }
}
