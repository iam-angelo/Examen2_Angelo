using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Examen2.Clases
{
    public class Usuarios
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }

        public Usuarios()
        {
            Nombre = string.Empty;
            CorreoElectronico = string.Empty;
            Telefono = string.Empty;
        }

        public Usuarios(string nombre, string correoElectronico, string telefono)
        {
            Nombre = nombre;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
        }

        public bool agregarUsuario()
        {
            int success = ProcedureSQL.insertarUsuario(Nombre, CorreoElectronico, Telefono);

            return success > 0;
        }

        public bool borrarUsuario()
        {
            int success = ProcedureSQL.borrarUsuariosPorId(Id);

            return success > 0;
        }

        public bool modificarUsuario()
        {
            int success = ProcedureSQL.actualizarUsuarioPorId(Id, Nombre, CorreoElectronico, Telefono);

            return success > 0;
        }

        public bool consultarUsuario(GridView dg)
        {
            int success = ProcedureSQL.consultarUsuariosPorId(Id, dg);

            return success > 0;
        }
    }
}
