using Examen2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Examen2
{
    public class DetallesReparacion
    {
        public int DetalleID { get; set; }
        public int ReparacionID { get; set; }
        public string Descripcion { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }

        public DetallesReparacion()
        {
            ReparacionID = 0;
            Descripcion = string.Empty;
            FechaFin = string.Empty;
            FechaInicio = string.Empty;
        }

        public bool agregarDetallesReparacion()
        {
            int success = ProcedureSQL.insertarDetalleReparacion(ReparacionID, Descripcion);

            return success > 0;
        }

        public bool borrarDetallesReparacion()
        {
            int success = ProcedureSQL.borrarDetallesReparacionPorId(DetalleID);

            return success > 0;
        }

        public bool modificarDetallesReparacion()
        {
            int success = ProcedureSQL.actualizarDetallesReparacionPorId(DetalleID, ReparacionID, Descripcion, FechaFin);

            return success > 0;
        }

        public bool consultarDetallesReparacion(GridView dg)
        {
            int success = ProcedureSQL.consultarDetallesReparacionPorId(DetalleID, dg);

            return success >= 0;
        }
    }
}