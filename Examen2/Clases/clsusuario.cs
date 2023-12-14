using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Examen2.Clases
{
    public class clsusuario
    {
        private static string pass;
        private static string user;

        public clsusuario(string Pass, string User) // iniciar las variable
        {
            pass = Pass;
            user = User;
        }

        public int MyProperty { get; set; }

        private static string nombre;


        public static string Getclave()
        {
            return pass;
        }

        public static string Getusuario()
        {
            return user;
        }

        public static string Getnombre()
        {
            return nombre;
        }
        public void SetClave(string contrasena)
        {
            pass = contrasena;
        }

        public void Setusuario(string User)
        {
            user = User;
        }

        
        public static int ValidarLogin()
        {
            int retorno = 0;
           
            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("validausuario1", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@Username", user));
                    cmd.Parameters.Add(new SqlParameter("@Pass", pass));

                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader lectura = cmd.ExecuteReader())
                    {
                        if (lectura.Read())
                        {
                            retorno = 1;
                            nombre = lectura[2].ToString();

                        }
                        else
                        {
                            retorno = -1;
                        }

                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                cnx2.Close();
                cnx2.Dispose();
            }

            return retorno;
        }
    }
}