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
            public static SqlConnection getConnection()
            {
                string conex1 = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
                SqlConnection cnx222 = new SqlConnection(conex1);
                cnx222.Open();

                return cnx222;
            }

            public static void closeConnection(SqlConnection cnx22)
            {
                cnx22.Close();
            }
        }
    }
