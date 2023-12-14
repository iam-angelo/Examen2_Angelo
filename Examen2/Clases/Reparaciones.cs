using Examen2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class Reparaciones
    {
        public int ReparacionID { get; set; }
        public int EquipoID { get; set; }
        public string FechaSolicitud { get; set; }
        public char Estado { get; set; }

        public Reparaciones()
        {
            EquipoID = 0;
            FechaSolicitud = string.Empty;
            Estado = 'z';
        }

        public bool agregarReparacion()
        {
            int success = ProcedureSQL.insertarReparacion(EquipoID, Estado);
           

            return success > 0;
        }

        public bool borrarReparacion()
        {
            int success = ProcedureSQL.borrarReparacionesPorId(ReparacionID);

            return success > 0;
        }

        public bool modificarReparacion()
        {
            int success = ProcedureSQL.actualizarReparacionPorId(ReparacionID, EquipoID, Estado);

            return success > 0;
        }

        public bool consultarReparacion(GridView dg)
        {
            int success = ProcedureSQL.consultarReparacionesPorId(ReparacionID, dg);

            return success > 0;
        }
    }
}