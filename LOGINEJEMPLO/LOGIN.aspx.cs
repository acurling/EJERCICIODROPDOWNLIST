using LOGINEJEMPLO.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOGINEJEMPLO
{
    public partial class LOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bagregar_Click(object sender, EventArgs e)
        {
            Clases.Clsusuarios objusuario = new Clases.Clsusuarios();
            objusuario.SetCorreo(tcorreo.Text);
            objusuario.SetClave(tclave.Text);
            if (Clsusuarios.ValidarLogin()>0)
            {
                Response.Redirect("home.aspx");
            }
           
        }
    }
}