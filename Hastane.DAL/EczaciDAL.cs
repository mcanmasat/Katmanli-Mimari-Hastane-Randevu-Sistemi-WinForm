using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hastane.DAL
{
    public class EczaciDAL
    {

        SqlDataReader rdr;
        public List<Eczaci> TumEczacilariGetir()
        {
            List<Eczaci> eczacilar = new List<Eczaci>();
            SqlCommand cmd = new SqlCommand("sp_EczacilariGetir", DBConnection.Conn);
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
                    Eczaci eczaci;
                    while (rdr.Read())
                    {
                        eczaci = new Eczaci()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            KullaniciAdi = rdr["KullaniciAdi"].ToString(),
                            Sifre = rdr["Sifre"].ToString()

                        };
                        eczacilar.Add(eczaci);
                    }
                }
                return eczacilar;
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
