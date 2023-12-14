using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Clases.clsusuario objusuario = new Clases.clsusuario(tclave.Text, tusuario.Text);
            if (Clases.clsusuario.ValidarLogin() > 0)
            {
                Response.Redirect("Asignaciones.aspx");
            }
        }
    }
}