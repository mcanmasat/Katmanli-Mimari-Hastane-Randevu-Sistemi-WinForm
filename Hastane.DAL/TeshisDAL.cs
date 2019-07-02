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
    public class TeshisDAL
    {
        SqlDataReader rdr;
        public List<Teshis> TumTeshisleriGetir()
        {
            List<Teshis> teshisler = new List<Teshis>();
            SqlCommand cmd = new SqlCommand("sp_TeshisleriGetir", DBConnection.Conn);
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
                    Teshis teshis;
                    while (rdr.Read())
                    {
                        teshis = new Teshis()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Adi = rdr["Ad"].ToString()

                        };
                        teshisler.Add(teshis);
                    }
                }
                return teshisler;
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
