using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class TahlilDAL
    {
        public int TahlilOlustur(Tahlil tahlil)
        {

            SqlCommand cmd = new SqlCommand("sp_TahlilEkle", DBConnection.Conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tahlilTurID", tahlil.TahlilTurID);
            cmd.Parameters.AddWithValue("@randevuID", tahlil.RandevuID);
            cmd.Parameters.AddWithValue("@yeniRandevuID", tahlil.YeniRandevuID);

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


    }
}
