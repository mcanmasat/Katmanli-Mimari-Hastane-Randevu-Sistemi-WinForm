using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class DBConnection
    {
        private static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HastaneDBConn"].ConnectionString);

        public static SqlConnection Conn
        {
            get { return conn; }

        }

        //Bağlantıyı Static tanımlayıp Property'den değerini geri döndürdük.

    }
}
