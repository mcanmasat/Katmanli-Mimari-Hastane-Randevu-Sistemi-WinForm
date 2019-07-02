using Hastane.Entities;
using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.DAL
{
    public class SeansDAL
    {
        SqlDataReader rdr;
        SqlDataReader rdr2;


        public List<Seans> SeanslariGetir(string randevuTarihi, int doktorID)
        {
            List<Seans> seanslar = new List<Seans>();
            SqlCommand cmd = new SqlCommand("sp_SeanslariKontrolEt", DBConnection.Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@randevuTarihi", randevuTarihi);
            cmd.Parameters.AddWithValue("@doktorID", doktorID);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Seans seans;
                    while (rdr.Read())
                    {
                        seans = new Seans()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            SeansAdi = rdr["SeansAdi"].ToString()

                        };
                        seanslar.Add(seans);
                    }
                }
                return seanslar;
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

        public List<string> SeansAdlariniGetir()
        {
            List<string> seanslar = new List<string>();
            SqlCommand cmd = new SqlCommand("sp_SeansAdlariniGetir", DBConnection.Conn);

            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Seans seans;
                    while (rdr.Read())
                    {
                        seans = new Seans()
                        {

                            SeansAdi = rdr["SeansAdi"].ToString()
                        };
                        //seanslar.Add içine direkt rdr'yi de yaazbiliriz.                        
                        seanslar.Add(seans.SeansAdi);
                    }
                }
                return seanslar;
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

        //public List<int> DoluSeansIDleriniGetir(string randevuTarihi, int doktorID)
        //{
        //    List<int> doluSeanslar = new List<int>();
        //    SqlCommand cmd = new SqlCommand("sp_DoluSeanslariGetir", DBConnection.Conn);
        //    cmd.Parameters.AddWithValue("@randevuTarihi", randevuTarihi);
        //    cmd.Parameters.AddWithValue("@doktorID", doktorID);

        //    try
        //    {
        //        if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
        //        {
        //            DBConnection.Conn.Open();
        //        }
        //        rdr = cmd.ExecuteReader();
        //        if (rdr.HasRows)
        //        {
        //            Seans doluSeans;
        //            while (rdr.Read())
        //            {
        //                doluSeans = new Seans()
        //                {
        //                    ID = Convert.ToInt32(rdr["ID"])
        //                };
        //                //seanslar.Add içine direkt rdr'yi de yaazbiliriz.                        
        //                doluSeanslar.Add(doluSeans.ID);
        //            }
        //        }
        //        return doluSeanslar;
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

        public List<int> DoluSeansIdleriGetir(string randevuTarihi2, int doktorID2)
        {
            List<int> doluSeanslar = new List<int>();
            SqlCommand cmd = new SqlCommand("[dbo].[sp_DoluSeanslariGetir]", DBConnection.Conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@randevuTarihi", randevuTarihi2);
            cmd.Parameters.AddWithValue("@doktorID", doktorID2);


            try
            {
                if (DBConnection.Conn.State != System.Data.ConnectionState.Open)
                {
                    DBConnection.Conn.Open();
                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Seans seans;
                    while (rdr.Read())
                    {
                        seans = new Seans()
                        {

                            ID = Convert.ToInt32(rdr["SeansID"])
                        };
                        //seanslar.Add içine direkt rdr'yi de yaazbiliriz.                        
                        doluSeanslar.Add(seans.ID);
                    }
                }
                return doluSeanslar;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
