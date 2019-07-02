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
    public class RandevuDAL
    {

        SqlDataReader rdr;

        public int RandevuOlustur(Randevu randevu)
        {

            SqlCommand cmd = new SqlCommand("sp_RandevuOlustur", DBConnection.Conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@hastaID", randevu.HastaID);
            cmd.Parameters.AddWithValue("@doktorID", randevu.DoktorID);
            cmd.Parameters.AddWithValue("@randevuTarihi", randevu.RandevuTarihi);
            cmd.Parameters.AddWithValue("@seansID", randevu.SeansID);

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

        public List<Randevu> HastaRandevulariGoruntule(int hastaID)
        {
            List<Randevu> randevular = new List<Randevu>();
            SqlCommand cmd = new SqlCommand("sp_HastaRandevulariGoruntule", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@hastaID", hastaID);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Randevu randevu;
                    while (rdr.Read())
                    {
                        randevu = new Randevu()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            HastaID = Convert.ToInt32(rdr["HastaID"]),
                            HastaneAdi = rdr["HastaneAdi"].ToString(),
                            KlinikAdi = rdr["KlinikAdi"].ToString(),
                            DoktorAdi = rdr["Ad"].ToString(),
                            DoktorSoyadi = rdr["Soyad"].ToString(),
                            RandevuTarihi = Convert.ToDateTime(rdr["Tarih"].ToString()),
                            SeansSaati = rdr["SeansAdi"].ToString()

                        };
                        randevular.Add(randevu);
                    }
                }
                return randevular;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                rdr.Close();
                DBConnection.Conn.Close();
            }
        }

        public int RandevuIptalEt(int randevuID)
        {
            SqlCommand cmd = new SqlCommand("sp_RandevuIptalEt", DBConnection.Conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@randevuID", randevuID);

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

        public List<Randevu> DoktorRandevulariGoruntule(int doktorID, string bugununTarihi)
        {
            List<Randevu> doktorRandevulari = new List<Randevu>();
            SqlCommand cmd = new SqlCommand("sp_DoktorRandevulariGoruntule", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@doktorID", doktorID);
            cmd.Parameters.AddWithValue("@bugununTarihi", bugununTarihi);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Randevu randevu;
                    while (rdr.Read())
                    {
                        randevu = new Randevu()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            HastaID = Convert.ToInt32(rdr["HastaID"]),
                            HastaAdi = rdr["Ad"].ToString(),
                            HastaSoyadi = rdr["Soyad"].ToString(),
                            RandevuTarihi = Convert.ToDateTime(rdr["Tarih"].ToString()),
                            SeansSaati = rdr["SeansAdi"].ToString()

                        };
                        doktorRandevulari.Add(randevu);
                    }
                }
                return doktorRandevulari;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                rdr.Close();
                DBConnection.Conn.Close();
            }
        }



        public int YeniRandevuOlustur(Randevu randevu)
        {

            SqlCommand cmd = new SqlCommand("sp_YeniRandevuOlustur", DBConnection.Conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@hastaID", randevu.HastaID);
            cmd.Parameters.AddWithValue("@doktorID", randevu.DoktorID);
            cmd.Parameters.AddWithValue("@tarih", randevu.RandevuTarihi);
            cmd.Parameters.AddWithValue("@seansID", randevu.SeansID);

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










    }
}
