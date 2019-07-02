using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class RandevuSonucDAL
    {

        public int RandevuSonucEkle(RandevuSonuc randevuSonuc)
        {

            SqlCommand cmd = new SqlCommand("sp_RandevuSonucEkle", DBConnection.Conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@randevuID", randevuSonuc.RandevuID);
            cmd.Parameters.AddWithValue("@muayeneGerceklestiMi", randevuSonuc.MuayeneGerceklestiMi);
            cmd.Parameters.AddWithValue("@muayeneNotlari", randevuSonuc.MuayeneNotlari);

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
