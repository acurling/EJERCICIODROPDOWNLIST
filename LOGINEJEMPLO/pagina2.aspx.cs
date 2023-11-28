using LOGINEJEMPLO.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOGINEJEMPLO
{
    public partial class pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Clases.Clsusuarios.GetNombre();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            GridView1.DataSource = Clsusuarios.ObtenerUsuarios();
            GridView1.DataBind();
        }
    }
}