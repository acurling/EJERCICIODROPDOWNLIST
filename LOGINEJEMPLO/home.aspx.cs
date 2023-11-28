using LOGINEJEMPLO.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOGINEJEMPLO
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                Label1.Text = Clsusuarios.GetNombre();
                Label2.Text = Clsusuarios.rol + " " + Clsusuarios.nombrerol;

        }
    }
}