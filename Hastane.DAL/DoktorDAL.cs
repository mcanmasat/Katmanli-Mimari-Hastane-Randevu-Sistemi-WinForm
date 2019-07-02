using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HastaneSistemi.Entities;

namespace Hastane.DAL
{
    public class DoktorDAL
    {

        SqlDataReader rdr;
        public List<Doktor> TumDoktorlariGetir()
        {
            List<Doktor> doktorlar = new List<Doktor>();
            SqlCommand cmd = new SqlCommand("sp_DoktorlariGetir", DBConnection.Conn);
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
                    Doktor doktor;
                    while (rdr.Read())
                    {
                        doktor = new Doktor()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            KullaniciAdi = rdr["KullaniciAdi"].ToString(),
                            Sifre = rdr["Sifre"].ToString()

                        };
                        doktorlar.Add(doktor);
                    }
                }
                return doktorlar;
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


        public int DoktorIDGetir(string kullaniciAdi)
        {
            SqlCommand cmd = new SqlCommand("sp_DoktorIDGetir", DBConnection.Conn);
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


        public string DoktorUnvanAdSoyadGetir(string kullaniciAdi)
        {
            SqlCommand cmd = new SqlCommand("sp_DoktorUnvanAdSoyadGetir", DBConnection.Conn);
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

    }
}
