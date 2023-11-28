using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Claims;
using LOGINEJEMPLO.Clases;

namespace LOGINEJEMPLO
{
    public partial class usuarioroles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) 
            
            {
                Llenarroles();
                Llenarusuarios();
            }
       
           
        }


        protected void Llenarroles()
        {
            string constr = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select id, descripcion from roles"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            drol.DataSource = dt;
                            drol.DataTextField = dt.Columns["descripcion"].ToString();
                            drol.DataValueField = dt.Columns["id"].ToString();
                            drol.DataBind(); // actualiza
                        }
                    }
                }
            }
        }


        protected void Llenarusuarios()
        {
            string constr = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select id, nombre from usuario"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dusuario.DataSource = dt;
                            dusuario.DataTextField = dt.Columns["nombre"].ToString();
                            dusuario.DataValueField = dt.Columns["id"].ToString();
                            dusuario.DataBind();
                        }
                    }
                }
            }
        }

        protected void bagregar_Click(object sender, EventArgs e)
        {
            int n = 0;
            n = n + 1;
        }

        protected void bactualizar_Click(object sender, EventArgs e)

        {
            ClsRoles.idrol = int.Parse(drol.SelectedValue.ToString());
            ClsRoles.idusuario = int.Parse(dusuario.SelectedValue.ToString()); 
            if (ClsRoles.Actualizarusuariorol()>0)
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}