using Examen2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Examen2
{
    public class Asignaciones
    {
        public int AsignacionID { get; set; }
        public int ReparacionID { get; set; }

        public int TecnicoID { get; set; }

        public string FechaAsignacion { get; set; }

        public Asignaciones()
        {
            ReparacionID = 0;
            TecnicoID = 0;
            FechaAsignacion = string.Empty;
        }

        public bool agregarAsignacion()
        {
            int success = ProcedureSQL.insertarAsignacion(ReparacionID, TecnicoID);
            

            return success > 0;
        }

        public bool borrarAsignacion()
        {
            int success = ProcedureSQL.borrarAsignacionesPorId(ReparacionID);

            return success > 0;
        }

        public bool modificarAsignacion()
        {
            int success = ProcedureSQL.actualizarAsignacionPorId(AsignacionID, ReparacionID, TecnicoID);

            return success > 0;
        }

        public bool consultarAsignacion(GridView dg)
        {
            int success = ProcedureSQL.consultarAsignacionesPorId(AsignacionID, dg);

            return success > 0;
        }
    }
}