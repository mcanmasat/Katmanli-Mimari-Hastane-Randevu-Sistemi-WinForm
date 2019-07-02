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
    public class TahlilTurDAL
    {
        SqlDataReader rdr;
        public List<TahlilTur> TumTahlilTurleriniGetir()
        {
            List<TahlilTur> tahlilTurleri = new List<TahlilTur>();
            SqlCommand cmd = new SqlCommand("sp_TahlilTurleriniGetir", DBConnection.Conn);
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
                    TahlilTur tahlilTur;
                    while (rdr.Read())
                    {
                        tahlilTur = new TahlilTur()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Kodu = rdr["Kodu"].ToString(),
                            Adi = rdr["Adi"].ToString()

                        };
                        tahlilTurleri.Add(tahlilTur);
                    }
                }
                return tahlilTurleri;
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
