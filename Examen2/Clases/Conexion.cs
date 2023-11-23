using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen2.Clases
{
    public class Conexion
    {
        public class Connexion
        {
            public static SqlConnection getConnection()
            {
                string conex1 = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
                SqlConnection cnx22 = new SqlConnection(conex1);
                cnx22.Open();

                return cnx22;
            }

            public static void closeConnection(SqlConnection cnx2)
            {
                cnx2.Close();
            }
        }
    }
}