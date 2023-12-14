using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
        public partial class DetallesReparacion : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    fillGrid();
                    fillReparaciones();
                }
            }

            protected void clearTxts()
            {
                txtId.Text = string.Empty;
                txtId.Focus();
                txtDescripcion.Text = string.Empty;
                txtFechaFin.Text = string.Empty;
            }

            protected void fillGrid()
            {
                int success = Clases.ProcedureSQL.consultarDetallesReparacion(dgDetalles);

                if (success > 0)
                {
                    Console.WriteLine(success.ToString());

                }

                clearTxts();
            }

            protected void fillReparaciones()
            {
                int success = Clases.ProcedureSQL.ConsultarReparacionesDetallesReparacion(ddRepracion);

                if (success > 0)
                {
                    Console.WriteLine(success.ToString());
                }
            }

            protected void add()
            {
                Examen2.DetallesReparacion detalle = new Examen2.DetallesReparacion();
                if (!ddRepracion.SelectedValue.Trim().Equals(string.Empty))
                {
                    detalle.ReparacionID = int.Parse(ddRepracion.SelectedValue.Trim());
                }
                else { return; }
                if (!txtDescripcion.Text.Trim().Equals(string.Empty))
                {
                    detalle.Descripcion = txtDescripcion.Text.Trim();
                }
                else { return; }

                if (detalle.agregarDetallesReparacion())
                
                {
                    fillGrid();
                }
            }

            protected void delete()
            {
                 Examen2.DetallesReparacion detalle = new Examen2.DetallesReparacion();
                if (!txtId.Text.Trim().Equals(string.Empty))
                {
                    detalle.DetalleID = int.Parse(txtId.Text.Trim());
                }
                else { return; }

                if (detalle.borrarDetallesReparacion())
                {
                    fillGrid();
                }
            }

            protected void modificar()
            {
                Examen2.DetallesReparacion detalle = new Examen2.DetallesReparacion();
                if (!txtId.Text.Trim().Equals(string.Empty))
                {
                    detalle.DetalleID = int.Parse(txtId.Text.Trim());
                }
                else { return; }
                if (!ddRepracion.SelectedValue.Trim().Equals(string.Empty))
                {
                    detalle.ReparacionID = int.Parse(ddRepracion.SelectedValue.Trim());
                }
                else { return; }
                if (!txtDescripcion.Text.Trim().Equals(string.Empty))
                {
                    detalle.Descripcion = txtDescripcion.Text.Trim();
                }
                else { return; }
                if (!txtFechaFin.Text.Trim().Equals(string.Empty))
                {
                    detalle.FechaFin = txtFechaFin.Text.Trim();
                }

                if (detalle.modificarDetallesReparacion())
                {
                    fillGrid();
                }
            }

            protected void consultar()
            {
            Examen2.DetallesReparacion detalle = new Examen2.DetallesReparacion();
                if (!txtId.Text.Trim().Equals(string.Empty))
                {
                    detalle.DetalleID = int.Parse(txtId.Text.Trim());
                }
                else { return; }

                if (detalle.consultarDetallesReparacion(dgDetalles))
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

            protected void dgDetalles_SelectedIndexChanged(object sender, EventArgs e)
            {
                string valueID = dgDetalles.Rows[dgDetalles.SelectedIndex].Cells[1].Text.ToString();
                string valueReparacion = dgDetalles.Rows[dgDetalles.SelectedIndex].Cells[2].Text.ToString();
                string valueDescripcion = dgDetalles.Rows[dgDetalles.SelectedIndex].Cells[3].Text.ToString();

                txtId.Text = valueID;
                ddRepracion.SelectedValue = valueReparacion;
                txtDescripcion.Text = valueDescripcion;
            }
        }
    }
