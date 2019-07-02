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
    public class IlacDAL
    {
        SqlDataReader rdr;
        public List<Ilac> TumIlaclariGetir()
        {
            List<Ilac> ilaclar = new List<Ilac>();
            SqlCommand cmd = new SqlCommand("sp_IlaclariGetir", DBConnection.Conn);
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
                    Ilac ilac;
                    while (rdr.Read())
                    {
                        ilac = new Ilac()
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Adi = rdr["Adi"].ToString()

                        };
                        ilaclar.Add(ilac);
                    }
                }
                return ilaclar;
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
