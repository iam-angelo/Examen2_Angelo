﻿using Examen2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class Asignaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillGrid();
                fillReparaciones();
                fillTecnicos();
            }
        }

        protected void fillGrid()
        {
            int success = Clases.ProcedureSQL.consultarAsignaciones(dgAsignaciones);
            
            if (success > 0)
            {
                Console.WriteLine(success);
            }
        }

        protected void fillReparaciones()
        {
            int success = Clases.ProcedureSQL.ConsultarReparacionesAsignaciones(ddRepracion);

            if (success > 0)
            {
                Console.WriteLine(success);
            }
        }

        protected void fillTecnicos()
        {
            int success = Clases.ProcedureSQL.ConsultarTecnicosAsignaciones(ddTecnico);

            if (success > 0)
            {
                Console.WriteLine(success);
            }
        }

        protected void add()
        {
            Clases.Asignaciones asignacion = new Clases.Asignaciones();
            if (!ddRepracion.SelectedValue.Trim().Equals(string.Empty))
            {
                asignacion.ReparacionID = int.Parse(ddRepracion.SelectedValue.Trim());
            }
            else { return; }
            if (!ddTecnico.SelectedValue.Trim().Equals(string.Empty))
            {
                asignacion.TecnicoID = int.Parse(ddTecnico.SelectedValue.Trim());
            }
            else { return; }
            if (!txtFecha.Text.Trim().Equals(string.Empty))
            {
                asignacion.FechaAsignacion = txtFecha.Text.Trim();
            }
            else { return; }

            if (asignacion.agregarAsignacion())
            {
                fillGrid();
            }

        }

        protected void delete()
        {
            Clases.Asignaciones asignacion = new Clases.Asignaciones();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                asignacion.AsignacionID = int.Parse(txtId.Text.Trim());
            }
            else { return; }

            if (asignacion.borrarAsignacion())
            {
                fillGrid();
            }
        }

        protected void modificar()
        {
            Clases.Asignaciones asignacion = new Clases.Asignaciones();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                asignacion.AsignacionID = int.Parse(txtId.Text.Trim());
            }
            else { return; }
            if (!ddRepracion.SelectedValue.Trim().Equals(string.Empty))
            {
                asignacion.ReparacionID = int.Parse(ddRepracion.SelectedValue.Trim());
            }
            else { return; }
            if (!ddTecnico.SelectedValue.Trim().Equals(string.Empty))
            {
                asignacion.TecnicoID = int.Parse(ddTecnico.SelectedValue.Trim());
            }
            else { return; }
            if (!txtFecha.Text.Trim().Equals(string.Empty))
            {
                asignacion.FechaAsignacion = txtFecha.Text.Trim();
            }
            else { return; }

            if (asignacion.modificarAsignacion())
            {
                fillGrid();
            }
        }

        protected void consultar()
        {
            Clases.Asignaciones asignacion = new Clases.Asignaciones();
            if (!txtId.Text.Trim().Equals(string.Empty))
            {
                asignacion.AsignacionID = int.Parse(txtId.Text.Trim());
            }
            else { return; }

            if (asignacion.consultarAsignacion(dgAsignaciones))
            {
                fillGrid();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            add();
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            delete();
        }

        protected void BtnModificar_Click(object senter, EventArgs e)
        {
            modificar();
        }

        protected void BtnConsultar_Click(object senter, EventArgs e)
        {
            consultar();
        }

        protected void BtnReset_Click(object senter, EventArgs e)
        {
            fillGrid();
        }
    }
}