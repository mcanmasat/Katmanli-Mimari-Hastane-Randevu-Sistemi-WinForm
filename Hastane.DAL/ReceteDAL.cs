using HastaneSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class ReceteDAL
    {

        public int ReceteEkle(Recete recete)
        {

            SqlCommand cmd = new SqlCommand("sp_ReceteOlustur", DBConnection.Conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@hastaID", recete.HastaID);
            cmd.Parameters.AddWithValue("@doktorID", recete.DoktorID);
            cmd.Parameters.AddWithValue("@teshisID", recete.TeshisID);
            cmd.Parameters.AddWithValue("@tarih", recete.Tarih);

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
