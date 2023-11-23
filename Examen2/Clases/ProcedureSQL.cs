using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using static Examen2.Clases.Conexion;
using System.Web.UI.WebControls;

namespace Examen2.Clases
{
    public class ProcedureSQL
    {
        
        /************************** Equipos ********************/
        public static int consultarEquipos(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_EQUIPO", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int ConsultarUsuariosEquipos(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_USUARIO", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;

                                dg.DataTextField = dt.Columns["Nombre"].ToString();
                                dg.DataValueField = dt.Columns["UsuarioID"].ToString();
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }
        public static int consultarEquiposPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_EQUIPO_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", id));
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int borrarEquiposPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRA_EQUIPO_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int insertarEquipo(string tipo, string modelo, int usuario)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTA_EQUIPO", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@TIPOEQUIPO", tipo));
                    cmd.Parameters.Add(new SqlParameter("@MODELO", modelo));
                    cmd.Parameters.Add(new SqlParameter("@USUARIOID", usuario));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int actualizarEquipoPorId(int id, string tipo, string modelo, int usuario)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZA_EQUIPO_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@TIPOEQUIPO", tipo));
                    cmd.Parameters.Add(new SqlParameter("@MODELO", modelo));
                    cmd.Parameters.Add(new SqlParameter("@USUARIOID", usuario));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        /************************** Tecnicos ********************/
        public static int consultarTecnicos(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_TECNICO", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int consultarTecnicosPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_TECNICO_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", id));
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int borrarTecnicosPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRA_TECNICO_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int insertarTecnico(string nombre, string especialidad)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTA_TECNICO", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@ESPECIALIDAD", especialidad));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int actualizarTecnicoPorId(int id, string nombre, string especialidad)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZA_TECNICO_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@ESPECIALIDAD", especialidad));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        /*************** Usuarios ***************/
        public static int consultarUsuarios(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_USUARIOS", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int consultarUsuariosPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_USUARIO_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        cmd.Parameters.Add(new SqlParameter("@ID", id));
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dg.DataSource = dt;
                                dg.DataBind();

                                ret = cmd.ExecuteNonQuery();
                            }
                        }
                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int borrarUsuariosPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRA_USUARIO_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int insertarUsuario(string nombre, string correo, string telefono)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTA_USUARIO", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@CORREO", correo));
                    cmd.Parameters.Add(new SqlParameter("@TELEFONO", telefono));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int actualizarUsuarioPorId(int id, string nombre, string correo, string telefono)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Connexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZA_USUARIO_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@NOMBRE", nombre));
                    cmd.Parameters.Add(new SqlParameter("@CORREO", correo));
                    cmd.Parameters.Add(new SqlParameter("@TELEFONO", telefono));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Connexion.closeConnection(cnx2);
            }

            return ret;
        }
    }
}
