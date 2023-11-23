using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class Tecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                fillGrid();
            }

            protected void fillGrid()
            {
                int success = Clases.ProcedureSQL.consultarTecnicos(dgTecnicos);

                if (success > 0)
                {
                    Console.Write(success.ToString());
                }
            }

            protected void add()
            {
                Clases.Tecnicos tecnico = new Clases.Tecnicos();
                if (!txtNombre.Text.Trim().Equals(string.Empty))
                {
                    tecnico.Nombre = txtNombre.Text.Trim();
                }
                else { return; }

                if (!txtEspecialidad.Text.Trim().Equals(string.Empty))
                {
                    tecnico.Especialidad = txtEspecialidad.Text.Trim();
                }
                else { return; }

                if (tecnico.agregarTecnico())
                {
                    fillGrid();
                }


            }

            protected void delete()
            {
                Clases.Tecnicos tecnico = new Clases.Tecnicos();
                if (!txtId.Text.Trim().Equals(string.Empty))
                {
                    tecnico.Id = int.Parse(txtId.Text.Trim());
                }
                else { return; }

                if (tecnico.borrarTecnico())
                {
                    fillGrid();
                }

            }

            protected void modificar()
            {
                Clases.Tecnicos tecnico = new Clases.Tecnicos();
                if (!txtId.Text.Trim().Equals(string.Empty))
                {
                    tecnico.Id = int.Parse(txtId.Text.Trim());
                }
                else { return; }
                if (!txtNombre.Text.Trim().Equals(string.Empty))
                {
                    tecnico.Nombre = txtNombre.Text.Trim();
                }
                else { return; }

                if (!txtEspecialidad.Text.Trim().Equals(string.Empty))
                {
                    tecnico.Especialidad = txtEspecialidad.Text.Trim();
                }
                else { return; }

                if (tecnico.modificarTecnico())
                {
                    fillGrid();
                }
            }

            protected void consultar()
            {
                Clases.Tecnicos tecnico = new Clases.Tecnicos();
                if (!txtId.Text.Trim().Equals(string.Empty))
                {
                    tecnico.Id = int.Parse(txtId.Text.Trim());
                }
                else { return; }

                if (tecnico.consultarTecnico(dgTecnicos))
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
    
