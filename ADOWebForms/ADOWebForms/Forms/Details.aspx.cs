using ADOWebForms.ADO;
using ADOWebForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.Forms
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) { 

            int id = Convert.ToInt32(Request.QueryString["id"]);

            ADOEstatusAlumno ado = new ADOEstatusAlumno();
            EstatusAlumno estatus = ado.Consultar(id);

            lblId.Text = estatus.id.ToString();
            lblClave.Text = estatus.clave.ToString();
            lblNombre.Text = estatus.nombre.ToString();

            }
        }
    }
}