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
    public class ReceteDetayDAL
    {

        public int ReceteyeIlacEkle(ReceteDetay receteDetay)
        {

            SqlCommand cmd = new SqlCommand("sp_ReceteyeIlacEkle", DBConnection.Conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@receteNumarasi", receteDetay.ReceteNumarasi);
            cmd.Parameters.AddWithValue("@ilacID", receteDetay.IlacID);
            cmd.Parameters.AddWithValue("@notlar", receteDetay.Notlar);

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

        SqlDataReader rdr;
        public List<ReceteDetay> EczaciIlacSorgula(int receteNumarasi)
        {
            List<ReceteDetay> receteDetaylar = new List<ReceteDetay>();
            SqlCommand cmd = new SqlCommand("sp_EczaciIlacSorgulama", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@receteNumarasi", receteNumarasi);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    ReceteDetay receteDetay;
                    while (rdr.Read())
                    {
                        receteDetay = new ReceteDetay()
                        {
                            IlacAdi = rdr["Adi"].ToString(),
                            Notlar = rdr["Notlar"].ToString()

                        };
                        receteDetaylar.Add(receteDetay);
                    }
                }
                return receteDetaylar;
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

        public List<ReceteDetay> HastaGecmisReceteSorgula(string tckn)
        {
            List<ReceteDetay> receteDetaylar = new List<ReceteDetay>();
            SqlCommand cmd = new SqlCommand("sp_HastaGecmisReceteSorgula", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tckn", tckn);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    ReceteDetay receteDetay;
                    while (rdr.Read())
                    {
                        receteDetay = new ReceteDetay()
                        {
                            ReceteNumarasi = Convert.ToInt32(rdr["ReceteNumarasi"]),
                            IlacAdi = rdr["Adi"].ToString(),
                            Notlar = rdr["Notlar"].ToString()

                        };
                        receteDetaylar.Add(receteDetay);
                    }
                }
                return receteDetaylar;
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
