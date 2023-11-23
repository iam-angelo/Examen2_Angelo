using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class Equipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillGrid();
                fillUsers();
            }

        }

        protected void fillGrid()
        {
            int success = Clases.ProcedureSQL.consultarEquipos(dgEquipos);

            if (success > 0)
            {
                Console.Write(success.ToString());
            }
        }

        protected void fillUsers()
        {
            int success = Clases.ProcedureSQL.ConsultarUsuariosEquipos(ddUsuario);
        }

        protected void add()
        {
            Clases.Equipos equipo = new Clases.Equipos();
            if (!txtTipoEquipo.Text.Trim().Equals(string.Empty))
            {
                equipo.TipoEquipo = txtTipoEquipo.Text.Trim();
            }
            else { return; }

            if (!txtModelo.Text.Trim().Equals(string.Empty))
            {
                equipo.Modelo = txtModelo.Text.Trim();
            }
            else { return; }

            if (!ddUsuario.SelectedValue.Trim().Equals(string.Empty))
            {
                equipo.UsuarioID = int.Parse(ddUsuario.SelectedValue.Trim());
            }
            else { return; }

            if (equipo.agregarEquipo())
            {
                fillGrid();
            }


        }

        protected void delete()
        {
            Clases.Usuarios equipo = new Clases.Usuarios();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                equipo.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }

            if (equipo.borrarUsuario())
            {
                fillGrid();
            }

        }

        protected void modificar()
        {
            Clases.Equipos equipo = new Clases.Equipos();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                equipo.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }
            if (!txtTipoEquipo.Text.Trim().Equals(string.Empty))
            {
                equipo.TipoEquipo = txtTipoEquipo.Text.Trim();
            }
            else { return; }

            if (!txtModelo.Text.Trim().Equals(string.Empty))
            {
                equipo.Modelo = txtModelo.Text.Trim();
            }
            else { return; }


            equipo.UsuarioID = int.Parse(ddUsuario.SelectedValue);

            if (equipo.modificarEquipo())
            {
                fillGrid();
            }
        }

        protected void consultar()
        {
            Clases.Usuarios equipo = new Clases.Usuarios();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                equipo.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }

            if (equipo.consultarUsuario(dgEquipos))
            {
                fillGrid();
            }
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            add();
        }

        protected void BtnDel_Click(object sender, EventArgs e)
        {
            delete();
        }

        protected void BtnMod_Click(object senter, EventArgs e)
        {
            modificar();
        }

        protected void BtnCheck_Click(object senter, EventArgs e)
        {
            consultar();
        }

        protected void BtnDefault_Click(object senter, EventArgs e)
        {
            fillGrid();
        }
    }
    }
