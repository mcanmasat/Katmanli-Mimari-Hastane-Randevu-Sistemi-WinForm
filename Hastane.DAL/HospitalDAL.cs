using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hastane.DAL
{
    public class HospitalDAL
    {
        SqlDataReader rdr;
        public List<Hospital> TumHastaneleriGetir()
        {
            List<Hospital> hastaneler = new List<Hospital>();
            SqlCommand cmd = new SqlCommand("sp_HastaneleriGetir", DBConnection.Conn);
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
                    Hospital hastane;
                    while (rdr.Read())
                    {
                        hastane = new Hospital()
                        {
                            HastaneKodu = Convert.ToInt32(rdr["HastaneKodu"]),
                            HastaneAdi = rdr["HastaneAdi"].ToString()

                        };
                        hastaneler.Add(hastane);
                    }
                }
                return hastaneler;
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

        public List<Hospital> KlinikleriGetir(int hastaneKodu)
        {
            List<Hospital> klinikler = new List<Hospital>();
            SqlCommand cmd = new SqlCommand("sp_KlinikleriGetir", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hastaneKodu", hastaneKodu);
            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Hospital klinik;
                    while (rdr.Read())
                    {
                        klinik = new Hospital()
                        {
                            KlinikAdi = rdr["KlinikAdi"].ToString()

                        };
                        klinikler.Add(klinik);
                    }
                }
                return klinikler;
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

        public List<Doktor> DoktorlariDoldur(int hastaneKodu, string klinikAdi)
        {
            List<Doktor> klinikDoktorlari = new List<Doktor>();
            SqlCommand cmd = new SqlCommand("sp_DoktorlariDoldur", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("klinikAdi", klinikAdi);
            cmd.Parameters.AddWithValue("@hastaneKodu", hastaneKodu);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Doktor klinikDoktor;
                    while (rdr.Read())
                    {
                        klinikDoktor = new Doktor()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Ad = rdr["Ad"].ToString(),
                            Soyad = rdr["Soyad"].ToString()

                        };
                        klinikDoktorlari.Add(klinikDoktor);
                    }
                }
                return klinikDoktorlari;
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

    }
}
