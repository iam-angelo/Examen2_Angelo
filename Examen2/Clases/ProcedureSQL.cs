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

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_EQUIPO", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int ConsultarUsuariosEquipos(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_USUARIO", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }
        public static int consultarEquiposPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_EQUIPO_ID", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int borrarEquiposPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRA_EQUIPO_ID", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int insertarEquipo(string tipo, string modelo, int usuario)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTA_EQUIPO", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int actualizarEquipoPorId(int id, string tipo, string modelo, int usuario)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZA_EQUIPO_ID", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        /************************** Tecnicos ********************/
        public static int consultarTecnicos(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_TECNICO", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int consultarTecnicosPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_TECNICO_ID", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int borrarTecnicosPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRA_TECNICO_ID", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int insertarTecnico(string nombre, string especialidad)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTA_TECNICO", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int actualizarTecnicoPorId(int id, string nombre, string especialidad)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZA_TECNICO_ID", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        /*************** Usuarios ***************/
        public static int consultarUsuarios(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_USUARIOS", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int consultarUsuariosPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTA_USUARIO_ID", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int borrarUsuariosPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRA_USUARIO_ID", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int insertarUsuario(string nombre, string correo, string telefono)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTA_USUARIO", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        public static int actualizarUsuarioPorId(int id, string nombre, string correo, string telefono)
        {
            int ret = 0;

            SqlConnection cnx22 = new SqlConnection();
            try
            {
                using (cnx22 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZA_USUARIO_ID", cnx22)
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
                Conexion.closeConnection(cnx22);
            }

            return ret;
        }

        /************************** DetallesReparacion ********************/
        public static int consultarDetallesReparacion(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_DETALLESREPARACION", cnx2)
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int ConsultarReparacionesDetallesReparacion(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_REPARACIONES", cnx2)
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

                                dg.DataTextField = dt.Columns["ReparacionID"].ToString();
                                dg.DataValueField = dt.Columns["ReparacionID"].ToString();
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }
        public static int consultarDetallesReparacionPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_DETALLESREPARACION_ID", cnx2)
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int borrarDetallesReparacionPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_DETALLESREPARACION_ID", cnx2)
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int insertarDetalleReparacion(int reparacionId, string descripcion)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTAR_DETALLESREPARACION", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@REPARACIONID", reparacionId));
                    cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", descripcion));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int actualizarDetallesReparacionPorId(int id, int reparacionId, string descripcion, string fechaFin)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR_DETALLESREPARACION_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@REPARACIONID", reparacionId));
                    cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", descripcion));
                    cmd.Parameters.Add(new SqlParameter("@FECHAFIN", fechaFin));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }
        /************************** Asignaciones ********************/
        public static int consultarAsignaciones(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_ASIGNACIONES", cnx2)
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int ConsultarReparacionesAsignaciones(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_REPARACIONES", cnx2)
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

                                dg.DataTextField = dt.Columns["ReparacionID"].ToString();
                                dg.DataValueField = dt.Columns["ReparacionID"].ToString();
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int ConsultarTecnicosAsignaciones(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_TECNICOS", cnx2)
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
                                dg.DataValueField = dt.Columns["TecnicoID"].ToString();
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }
        public static int consultarAsignacionesPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_ASIGNACIONES_ID", cnx2)
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int borrarAsignacionesPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_ASIGNACIONES_ID", cnx2)
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int insertarAsignacion(int reparacionId, int tecnicoId)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTAR_ASIGNACION", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@REPARACIONID", reparacionId));
                    cmd.Parameters.Add(new SqlParameter("@TECNICOID", tecnicoId));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int actualizarAsignacionPorId(int id, int reparacionId, int tecnicoId)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR_ASIGNACION_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@REPARACIONID", reparacionId));
                    cmd.Parameters.Add(new SqlParameter("@TECNICOID", tecnicoId));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }
        /************************** Reparaciones ********************/
        public static int consultarReparaciones(GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_REPARACIONES", cnx2)
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int ConsultarEquiposReparaciones(DropDownList dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_EQUIPOS", cnx2)
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

                                dg.DataTextField = dt.Columns["TipoEquipo"].ToString();
                                dg.DataValueField = dt.Columns["EquipoID"].ToString();
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }
        public static int consultarReparacionesPorId(int id, GridView dg)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("CONSULTAR_REPARACIONES_ID", cnx2)
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int borrarReparacionesPorId(int id)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_REPARACIONES_ID", cnx2)
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
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int insertarReparacion(int equipId, char estado)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("INSERTAR_REPARACION", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@EQUIPOID", equipId));
                    cmd.Parameters.Add(new SqlParameter("@ESTADO", estado));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }

        public static int actualizarReparacionPorId(int id, int equipId, char estado)
        {
            int ret = 0;

            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR_EQUIPO_ID", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@EQUIPOID", equipId));
                    cmd.Parameters.Add(new SqlParameter("@ESTADO", estado));

                    ret = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ret = -1;
            }
            finally
            {
                Conexion.closeConnection(cnx2);
            }

            return ret;
        }
        public static int validarLogin(string Username, string Password)
        {
            int ret = 0;
            SqlConnection cnx2 = new SqlConnection();
            try
            {
                using (cnx2 = Conexion.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("VALIDAR_LOGIN1", cnx2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@USERNAME", Username));
                    cmd.Parameters.Add(new SqlParameter("@PASSWORD", Password));

                    int result = cmd.ExecuteNonQuery();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            ret = rdr.GetInt32(0);
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
                Conexion.closeConnection(cnx2);
            }


            return ret;


        }
    }

}
