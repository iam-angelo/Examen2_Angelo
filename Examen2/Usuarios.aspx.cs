using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            fillGrid();
        }

        protected void fillGrid()
        {
            int success = Clases.ProcedureSQL.consultarUsuarios(dgUsuarios);

            if (success > 0)
            {
                Console.Write(success.ToString());
            }
        }

        protected void add()
        {
            Clases.Usuarios user = new Clases.Usuarios();
            if (!txtNombre.Text.Trim().Equals(string.Empty))
            {
                user.Nombre = txtNombre.Text.Trim();
            }
            else { return; }

            if (!txtCorreo.Text.Trim().Equals(string.Empty))
            {
                user.CorreoElectronico = txtCorreo.Text.Trim();
            }
            else { return; }

            if (!txtTelefono.Text.Trim().Equals(string.Empty))
            {
                user.Telefono = txtTelefono.Text.Trim();
            }
            else { return; }

            if (user.agregarUsuario())
            {
                fillGrid();
            }


        }

        protected void delete()
        {
            Clases.Usuarios user = new Clases.Usuarios();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                user.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }

            if (user.borrarUsuario())
            {
                fillGrid();
            }

        }

        protected void modificar()
        {
            Clases.Usuarios user = new Clases.Usuarios();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                user.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }
            if (!txtNombre.Text.Trim().Equals(string.Empty))
            {
                user.Nombre = txtNombre.Text.Trim();
            }
            else { return; }

            if (!txtCorreo.Text.Trim().Equals(string.Empty))
            {
                user.CorreoElectronico = txtCorreo.Text.Trim();
            }
            else { return; }

            if (!txtTelefono.Text.Trim().Equals(string.Empty))
            {
                user.Telefono = txtTelefono.Text.Trim();
            }
            else { return; }

            if (user.modificarUsuario())
            {
                fillGrid();
            }
        }

        protected void consultar()
        {
            Clases.Usuarios user = new Clases.Usuarios();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                user.Id = int.Parse(txtId.Text.Trim());
            }
            else { return; }

            if (user.consultarUsuario(dgUsuarios))
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
        
    
